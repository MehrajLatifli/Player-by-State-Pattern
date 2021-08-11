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
    public class Player
    {
        public IState _State { get; set; }

        public Player(IState State)
        {
            _State = State;
        }
      public  void Add(MediaPlayer mediaPlayer, string location, MainWindow mainWindow)
        {
            _State.AddButton( mediaPlayer,  location, mainWindow);
        }

        public void Play(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            _State.PlayButton(mediaPlayer, FileList, mainWindow);
        }

        public void Pause(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            _State.PauseButton(mediaPlayer, FileList, mainWindow);
        }

        public void Stop(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            _State.StopButton(mediaPlayer, FileList, mainWindow);
        }

        public void Time(MediaPlayer mediaPlayer, TimeSpan timeSpan, MainWindow mainWindow)
        {
            _State.TimePlayer(mediaPlayer, timeSpan, mainWindow);
        }
    }
}
