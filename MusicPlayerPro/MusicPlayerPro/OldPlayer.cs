using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Media;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using Path = System.IO.Path;


namespace MusicPlayerPro
{
    public class OldPlayer
    {
       
        MediaPlayer _mediaPlayer = new MediaPlayer();

        public OldPlayer()
        {
           
        }

        public void PlayTheSong()
        {
           // _mediaPlayer.Play();
        }

        public void PauseTheSong()
        {
           // _mediaPlayer.Pause();
        }

        public void RewindTheSong()
        {
           // _mediaPlayer.Position.TotalSeconds;
        }

        internal void OpenTheMusic(Uri uri)
        {
           // _mediaPlayer.Open(uri);
        }
    }
}
