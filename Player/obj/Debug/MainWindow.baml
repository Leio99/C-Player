   M S B A M L   `   `   `  ����A  =Player, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PlayerPlayer  5   	       Player.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Player     5   	     � Title$  Music player��5   	   $	��450��6   $	��710��6+    � 
ResizeMode$ CanMinimize=�67    � Icon$ icon.ico��6P   .��5	      � .+�5
   
   �� -   5         ��Name$ songlist��5
       � Cursor$
 Hand��6$   $
��Left=�62   $	��248��6M   $��0,40,0,0q�6Y   $��0,1,1,0q�6�   �� 5   
   ���	#FFABADB3$��0,0,1,1q�6)   $
��Left=�6C   $��41��6^   $	��Top=�6j   $	��248��6�   ._�5      �� $��YOUR PLAYLIST��6   $��DemiBold"�6,   $��Center=�6B   $��Center=�6f   $��-0.8,0.2,0.2,0.2q�6�   5      �� 5   
   $��1q�6    K� ZIndex$ 2��6%   $��1��66   $	��Top=�6A   ���	#FFABADB3$��0q�6q   �� 5   
   -   5         ��Name$ infotext��5   %   $y�Visible=�6   $%��Select a song from the playlist��67   $��248,1,-0.4,0q�6a   $��30(�6w   $��Center=�6�   $��Center=�6�   ���	#FF9696966�   � 5   
   -   5         �Name$ player_desk��5      $y�Hidden=�6$   $��248,2,-0.4,0q�68   .+�5      �� -   5         ��Name$ 	playpause��5      $
 Hand��6'   	 � ToolTip$
	 Play��65   $��Center=�6D   $	��154��6a   $%��https://i.imgur.com/pYOZg1A.png��6n   $��0,70,0,0q�6�   $	��Top=�6�   $	��154��6�   6�   �� 5      -   5        
 ��Name$
 start��5      $��00:00:00��6'   $
��Left=�67   $��
20,343,0,0q�6R   $	��Top=�6f   �� 5      -   5        $	
 end��5      $��
0,343,20,0q�6%   $��00:00:00��69    �� TextAlignment$ Right=�6I   $	��Top=�6_   $��Right=�6w   $��49��6�   �� 5      -   5        $
 progress��5      $ 1��6*   $��2��6;   $��
74,351,0,0q�6F   $
��Wrap=�6Z   ���	#FF2E70DF$	��Top=�6�   $
��Left=�6�   $��0��6�   �� 5      $��2��6   $��
74,351,0,0q�6#   $
��Wrap=�67   ���	#FFB1B1B1$	��Top=�6b   $
��Left=�6z   $	��300��6�   �� 5      -   5        $
 	songtitle��5      $��	0,243,0,0q�6+   $
��Wrap=�6>   $��20(�6R   $ Center=�6`   $	��Top=�6w   $��30��6�   
�������6�   �� 5      -	   5         ��Name$ autoplay��5   a   $"��Automatically play next song��6   $��Right=�6>   $��
0,380,20,0q�6s   $
 Hand��6�   $	��Top=�6�   $��Right=�6�   $	��175��6�   6�   �� 5      -
   5        $%��https://i.imgur.com/3Iu2fSv.png��5      $	��100��6=   $
 Hand��6J   $��321,103,35.4,0q�6X   $	��Top=�6p   6�   �� 5      -   5        $%��https://i.imgur.com/kugOwpz.png��5      $	��100��6=   $
 Hand��6J   $��36,103,320.4,0q�6X   $	��Top=�6p   6�   �� 5      -   5        $
 loop��5   H   $
��Loop��6   $
��Left=�6&   $��
20,380,0,0q�6V   $
 Hand��6j   $	��Top=�6x   $
��Left=�6�   $	��175��6�   6�   5      5      5      