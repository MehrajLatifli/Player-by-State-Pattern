﻿using System;
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
    public class PauseState : IState
    {
        MediaPlayer MediaPlayer { get; set; }
        public PauseState(MediaPlayer mediaPlayer)
        {
            MediaPlayer = mediaPlayer;
        }

        public void PauseButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
           
            MediaPlayer.Pause();
        }



        public void PlayButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"PauseState can not control Play");
        }

        public void StopButton(MediaPlayer mediaPlayer, ObservableCollection<Files> FileList, MainWindow mainWindow)
        {
            MessageBox.Show($"PauseState can not control Stop");
        }

        public void AddButton(MediaPlayer mediaPlayer, string location, MainWindow mainWindow)
        {
            MessageBox.Show($"PauseState can not control Add");
        }
    }
}
