using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace Player_by_State_Pattern.State_Pattern
{
    public class StopState : IState
    {
        MediaPlayer MediaPlayer { get; set; }
        public StopState(MediaPlayer mediaPlayer)
        {
            MediaPlayer = mediaPlayer;
        }

        public void AddButton(MediaPlayer mediaPlayer, string location, MainWindow mainWindow)
        {
            MessageBox.Show($"StopState can not control Add");
        }

        public void PauseButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"StopState can not control Pause");
        }

        public void PlayButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"StopState can not control Play");
        }

        public void StopButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            
            MediaPlayer.Stop();
        }


    }
}
