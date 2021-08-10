using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Player_by_State_Pattern.State_Pattern
{
   public interface IState
    {
        void PlayButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow);
        void PauseButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow);
        void StopButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow);
        void AddButton(MediaPlayer mediaPlayer, string location, MainWindow mainWindow);
    }
}
