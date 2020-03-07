using System;

namespace Player
{
    public class Song
    {
        public string title { get; private set; }
        public string singer { get; private set; }
        public TimeSpan duration { get; private set; }
        public string directory { get; private set; }
        
        public Song(string title, string singer, TimeSpan duration, string directory)
        {
            this.title = title;
            this.singer = singer;
            this.duration = duration;
            this.directory = directory;
        }

        public override string ToString()
        {
            return title;
        }
    }
}
