using System;
using System.Windows.Controls;
using UI_MusicPlayer;

namespace MusicPlayerPro
{
    public class ViewModel
    {
        public string GetSongName(ListBox _listbox)
        {
            return _listbox.SelectedItem.ToString();
        }

    }
}
