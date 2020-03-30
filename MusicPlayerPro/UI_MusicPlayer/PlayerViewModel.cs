using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media;
using UI_MusicPlayer.Command;

namespace MusicPlayerPro
{
    public class PlayerViewModel
    {
        private const string _musicpath = @"D:\musicD";
        private readonly DirectoryInfo _directoryInfo = new DirectoryInfo(_musicpath);

        private readonly Player _player;

        public PlayerViewModel()
        {
            _player = new Player();


            PathCollection = new List<FileInfo>();
            {
                PathCollection.AddRange(_directoryInfo.GetFiles(".mp3"));
            }

            TrackCollection = new List<string>(); /*ObservableCollection<string>()*/
            {
                var files = Directory.GetFiles(_musicpath);


                foreach (var file in files)
                    if (Path.GetExtension(file) == ".mp3")
                        TrackCollection.Add(Path.GetFileNameWithoutExtension(file));
            }
            ;


            PauseMusicCommand = new RelayCommand(_ => true, _ => PauseMusic());
            PlayMusicCommand = new RelayCommand(_ => true, _ => PlayMusic());
            StopMusicCommand = new RelayCommand(_ => true, _ => StopMusic());
        }

        //public ObservableCollection<string> TrackCollection { get; private set; }
        public List<string> TrackCollection { get; }
        public RelayCommand PauseMusicCommand { get; }
        public RelayCommand PlayMusicCommand { get; }
        public RelayCommand StopMusicCommand { get; }
        public List<FileInfo> PathCollection { get; }


        private bool _isPaused =false;

        private void PauseMusic()
        {
            _player.PauseTheSong();
            _isPaused = true;
        }

        private void PlayMusic()
        {
            if(!_isPaused)
                _player.OpenTheMusic(new Uri(@"D:\musicD\Yung_Lean_Afganistan.mp3"));
            _player.PlayTheSong();
        }

        private void StopMusic()
        {
            _player.PauseTheSong();
        }

        public static string GetSongName(ListBox _listbox)
        {
            return _listbox.SelectedItem.ToString();
        }
    }
}