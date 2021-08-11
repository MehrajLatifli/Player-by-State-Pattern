using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Player_by_State_Pattern.State_Pattern
{
    public class TimeState : IState
    {
        MediaPlayer MediaPlayer { get; set; }
        public TimeState(MediaPlayer mediaPlayer)
        {
            MediaPlayer = mediaPlayer;
        }

        public void AddButton(MediaPlayer mediaPlayer, string location, MainWindow mainWindow)
        {
            MessageBox.Show($"TimeState can not control Add");
        }

        public void PauseButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"TimeState can not control Pause");
        }

        public void PlayButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"TimeState can not control Play");
        }

        public void StopButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"TimeState can not control Stop");
        }

        public void TimePlayer(MediaPlayer mediaPlayer, TimeSpan timeSpan, MainWindow mainWindow)
        {

            mainWindow.TimeLabel.Content = string.Format("{0}      <==>      {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));


            mainWindow.TimeSlider.Visibility = Visibility.Visible;

            timeSpan = mediaPlayer.NaturalDuration.TimeSpan;

            mainWindow.TimeSlider.Minimum = 0;
            mainWindow.TimeSlider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
            mainWindow.TimeSlider.SmallChange = 1;
            mainWindow.TimeSlider.LargeChange = Math.Min(10, timeSpan.Seconds / 10);

            mainWindow.TimeSlider.Value = mediaPlayer.Position.TotalSeconds;
        }
    }
}
