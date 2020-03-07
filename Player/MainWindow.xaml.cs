using System;
using System.Media;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Timers;
using System.Linq;

namespace Player
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SoundPlayer player;
        public bool playing = false;
        public MainWindow()
        {
            InitializeComponent();

            checkSongFolder();
        }

        public void checkSongFolder()
        {
            if (!Directory.Exists("songs"))
                Directory.CreateDirectory("songs");

            var dir = new DirectoryInfo("songs");
            FileInfo[] songs = dir.GetFiles("*.wav").OrderBy(f => f.Name).ToArray();

            foreach (FileInfo f in songs)
            {
                string title = f.Name;
                string directory = "songs/" + title;

                title = title.Substring(0, title.Length - 4);

                TagLib.File tagFile = TagLib.File.Create(directory);

                TimeSpan duration = TimeSpan.Parse(tagFile.Properties.Duration.ToString().Split('.')[0]);

                Song s = new Song(title, "MJ", duration, directory);

                songlist.Items.Add(s);
            }

        }

        public void playSong(string dir)
        {
            try
            {
                player = new SoundPlayer(dir);
                player.Play();

                playpause.Source = new BitmapImage(new Uri("https://i.imgur.com/WyIDc4l.png"));
                playpause.ToolTip = "Stop";

                playing = true;

                InitTimer();
            }
            catch { }
        }

        public void stopSong()
        {
            player.Stop();

            playpause.Source = new BitmapImage(new Uri("https://i.imgur.com/pYOZg1A.png"));
            playpause.ToolTip = "Play";
            progress.Width = 0;
            start.Text = "00:00:00";
            playing = false;
            timer.Stop();
        }

        private void playThisSong(object sender, MouseButtonEventArgs e)
        {
            if (playing)
            {
                Songlist_SelectionChanged(null, null);
                return;
            }

            Song s = songlist.SelectedItem as Song;
            playSong(s.directory);
        }

        private void Songlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            player_desk.Visibility = Visibility.Visible;
            infotext.Visibility = Visibility.Hidden;

            if (playing)
                stopSong();

            Song s = songlist.SelectedItem as Song;
            start.Text = "00:00:00";
            end.Text = s.duration.ToString();
            progress.Width = 0;
            songtitle.Text = s.title;
        }

        public Timer timer;
        
        public void InitTimer()
        {
            timer = new Timer(1000);
            timer.AutoReset = true;
            timer.Elapsed += new ElapsedEventHandler(oneSecondAdd);
            timer.Start();
        }

        public void oneSecondAdd(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                if (start.Text == end.Text)
                {
                    stopSong();
                    Songlist_SelectionChanged(null, null);
                    checkForNextSong();
                    return;
                }

                TimeSpan time = TimeSpan.Parse(start.Text);
                start.Text = (time + new TimeSpan(0, 0, 1)).ToString();

                double total = TimeSpan.Parse(end.Text).TotalSeconds;
                double current = TimeSpan.Parse(start.Text).TotalSeconds;

                // 100 : total = x : current -> 100 * current / total = 10
                // width * x / 100 

                double x = (100 * current) / total;
                double width = 300 * (x / 100);

                progress.Width = width;
            });
        }
        
        public void checkForNextSong(bool notclicked = true)
        {
            if (loop.IsChecked == true)
            {
                playThisSong(null, null);
                return;
            }

            if (songlist.SelectedIndex == songlist.Items.Count - 1 || (autoplay.IsChecked == false && notclicked))
                return;

            songlist.SelectedIndex = songlist.SelectedIndex + 1;
            playThisSong(null, null);
        }

        private void playNextSong(object sender, MouseButtonEventArgs e)
        {
            checkForNextSong(false);
        }

        private void playPreviousSong(object sender, MouseButtonEventArgs e)
        {
            if (songlist.SelectedIndex == 0)
                return;

            songlist.SelectedIndex = songlist.SelectedIndex - 1;
            playThisSong(null, null);
        }

        private void switchLoop(object sender, RoutedEventArgs e)
        {
            autoplay.IsChecked = false;
        }

        private void switchAutoplay(object sender, RoutedEventArgs e)
        {
            loop.IsChecked = false;
        }
    }
}
