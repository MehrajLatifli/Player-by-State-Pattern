using Microsoft.Win32;
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
    public class AddState : IState
    {
        public void AddButton(MediaPlayer mediaPlayer, string location, MainWindow mainWindow)
        {
            mainWindow.AddMenuButton.IsChecked = true;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {

                location = openFileDialog.FileName;

               

                MessageBox.Show($"{location}");

                mainWindow.add(location);
            }
        }

        public void PauseButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"AddState can not control Pause");
        }

        public void PlayButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"AddState can not control Play");
        }

        public void StopButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"AddState can not control Stop");
        }

        public void TimePlayer(MediaPlayer mediaPlayer, TimeSpan timeSpan, MainWindow mainWindow)
        {
            MessageBox.Show($"AddState can not control Time");
        }
    }
}
