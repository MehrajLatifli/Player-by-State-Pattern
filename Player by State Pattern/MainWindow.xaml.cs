using Microsoft.Win32;
using Player_by_State_Pattern.State_Pattern;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Player_by_State_Pattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Files> FileList { get; set; }
        public ObservableCollection<Files> nList = new ObservableCollection<Files>();

         private bool _isDragging = false;



        public MainWindow()
        {
            string Filepath_1 = "../../Files/Şövkət Ələkbərova - Gedək üzü küləyə.mp3";
            FileInfo FileInfo_1 = new FileInfo(Filepath_1);
            var FileFolder_1 = new DirectoryInfo(Filepath_1);


            string Filepath_2 = "../../Files/Barış Akarsu - Kimdir O.mp3";
            FileInfo FileInfo_2 = new FileInfo(Filepath_2);
            var FileFolder_2 = new DirectoryInfo(Filepath_2);

            string Filepath_3 = "../../Files/Barış Manço - Ali Yazar Veli Bozar.mp3"; ;
            FileInfo FileInfo_3 = new FileInfo(Filepath_3);
            var FileFolder_3 = new DirectoryInfo(Filepath_3);

            string Filepath_4 = "../../Files/Belkıs Özener - Hayat Sevince Güzel.mp3"; ;
            FileInfo FileInfo_4 = new FileInfo(Filepath_4);
            DirectoryInfo FileFolder_4 = new DirectoryInfo(Filepath_4);

            string Filepath_5 = "../../Files/Boney M - Daddy Cool.mp3"; ;
            FileInfo FileInfo_5 = new FileInfo(Filepath_5);
            DirectoryInfo FileFolder_5 = new DirectoryInfo(Filepath_5);

            string Filepath_6 = "../../Files/Diane Warren - Unbreak My Heart.mp3"; ;
            FileInfo FileInfo_6 = new FileInfo(Filepath_6);
            DirectoryInfo FileFolder_6 = new DirectoryInfo(Filepath_6);

            string Filepath_7 = "../../Files/Emin Sabitoğlu - Ad günü filminin fon musiqisi.mp3"; ;
            FileInfo FileInfo_7 = new FileInfo(Filepath_7);
            DirectoryInfo FileFolder_7 = new DirectoryInfo(Filepath_7);

            string Filepath_8 = "../../Files/Farid Farjad - Fikrimin ince gülü.mp3"; ;
            FileInfo FileInfo_8 = new FileInfo(Filepath_8);
            DirectoryInfo FileFolder_8 = new DirectoryInfo(Filepath_8);

            FileList = new ObservableCollection<Files>
            {
                new Files
                {
                    FileShortName=$"{FileInfo_1.Name}",
                    FileName=$"{FileInfo_1.FullName}",
                    FileAddDateTime= $" Add Time: {DateTime.Now.ToLocalTime()}",
                    FilePath=Filepath_1,
                    FolderofFile=$" Folder of File: {FileFolder_1}",
                    FileİmagePath="../../Files/cover.png",
                },

                new Files
                {
                    FileShortName=$"{FileInfo_2.Name}",
                    FileName=$"{FileInfo_2.FullName}",
                    FileAddDateTime= $" Add Time: {DateTime.Now.ToLocalTime()}",
                    FilePath=Filepath_2,
                    FolderofFile=$" Folder of File: {FileFolder_2}",
                    FileİmagePath="../../Files/cover.png",
                },

                new Files
                {
                    FileShortName=$"{FileInfo_3.Name}",
                    FileName=$"{FileInfo_3.FullName}",
                    FileAddDateTime= $" Add Time: {DateTime.Now.ToLocalTime()}",
                    FilePath=Filepath_3,
                    FolderofFile=$" Folder of File: {FileFolder_3}",
                    FileİmagePath="../../Files/cover.png",
                },

                new Files
                {
                    FileShortName=$"{FileInfo_4.Name}",
                    FileName=$"{FileInfo_4.FullName}",
                    FileAddDateTime= $" Add Time: {DateTime.Now.ToLocalTime()}",
                    FilePath=Filepath_4,
                    FolderofFile=$" Folder of File: {FileFolder_4}",
                    FileİmagePath="../../Files/cover.png",
                },

                  new Files
                {
                    FileShortName=$"{FileInfo_5.Name}",
                    FileName=$"{FileInfo_5.FullName}",
                    FileAddDateTime= $" Add Time: {DateTime.Now.ToLocalTime()}",
                    FilePath=Filepath_5,
                    FolderofFile=$" Folder of File: {FileFolder_5}",
                    FileİmagePath="../../Files/cover.png",
                },

                new Files
                {
                    FileShortName=$"{FileInfo_6.Name}",
                    FileName=$"{FileInfo_6.FullName}",
                    FileAddDateTime= $" Add Time: {DateTime.Now.ToLocalTime()}",
                    FilePath=Filepath_6,
                    FolderofFile=$" Folder of File: {FileFolder_6}",
                    FileİmagePath="../../Files/cover.png",
                },

                new Files
                {
                    FileShortName=$"{FileInfo_7.Name}",
                    FileName=$"{FileInfo_7.FullName}",
                    FileAddDateTime= $" Add Time: {DateTime.Now.ToLocalTime()}",
                    FilePath=Filepath_7,
                    FolderofFile=$" Folder of File: {FileFolder_7}",
                    FileİmagePath="../../Files/cover.png",
                },

                new Files
                {
                    FileShortName=$"{FileInfo_8.Name}",
                    FileName=$"{FileInfo_8.FullName}",
                    FileAddDateTime= $" Add Time: {DateTime.Now.ToLocalTime()}",
                    FilePath=Filepath_8,
                    FolderofFile=$" Folder of File: {FileFolder_8}",
                    FileİmagePath="../../Files/cover.png",
                },
            };

            this.DataContext = this;



            InitializeComponent();
        }


        public object selecti;

        private void Listbox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                selecti = Listbox1.SelectedItem;

                mediaPlayer.Open(new Uri(FileList[Listbox1.SelectedIndex].FilePath, UriKind.RelativeOrAbsolute));

                Timer();

            }
            catch (Exception)
            {


            }

        }

        string location = "";



        private MediaPlayer mediaPlayer = new MediaPlayer();


        private void SearchTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

            Listbox1.ItemsSource = null;

            if (string.IsNullOrEmpty(SearchTextbox.Text) == false)
            {
                Listbox1.ItemsSource = null;
                Listbox1.Items.Clear();

                foreach (var item in FileList)
                {
                    if (item.FileShortName.StartsWith(SearchTextbox.Text))
                    {
                        Listbox1.Items.Add(item);
                    }
                    Listbox1.ItemsSource = null;
                }
            }

            else
            {
                Listbox1.Items.Clear();

                foreach (var item in FileList)
                {

                    Listbox1.Items.Add(item);


                }
            }


        }

        public void add(string location)
        {

            addList(location);

            try
            {
                Listbox1.ItemsSource = null;

                Listbox1.Items.Clear();

                foreach (var item in FileList)
                {

                    Listbox1.Items.Add(item);

                }

                Listbox1.ItemsSource = FileList;
            }
            catch (Exception)
            {


            }


            Listbox1.ItemsSource = null;
        }
        public void addList(string location)
        {
            Listbox1.ItemsSource = null;

            Listbox1.Items.Clear();



            DirectoryInfo d = new DirectoryInfo(location);

            Listbox1.ItemsSource = null;

            Listbox1.Items.Clear();




            FileList.Add(new Files()
            {
                FileShortName = $"{System.IO.Path.GetFileName(location)}",
                FileName = $"{System.IO.Path.GetFileName(location)}",
                FileAddDateTime = $" Add Time: {DateTime.Now.ToLocalTime()}",
                FilePath = $"{ location}",
                FolderofFile = $" Folder of File: {d}",
                FileİmagePath = "Files/cover.png",

            });




        }

        private void AddMenuButton_Click(object sender, RoutedEventArgs e)
        {

            Player add = new Player(new AddState());

            add._State.AddButton(mediaPlayer, location, this);




        }





        ObservableCollection<Files> MyData { get; set; }



      

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {


            Player play = new Player(new PlayState(mediaPlayer));

            play.Play(mediaPlayer, FileList, this);

            Timer();


            if (mediaPlayer.Source == null) { 
                for (int i = 0; i < 1; i++)
                {

                    MessageBox.Show("No file selected...");
                    break;
                }

            }

        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            Player play = new Player(new StopState(mediaPlayer));

            play.Stop(mediaPlayer, FileList, this);

            Timer();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            Player play = new Player(new PauseState(mediaPlayer));

            play.Pause(mediaPlayer, FileList, this);


            Timer();
        }

        public void Timer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (mediaPlayer.Source != null)
                {

                    TimeLabel.Content = string.Format("{0}      <==>      {1}", mediaPlayer.Position.ToString(@"mm\:ss"), mediaPlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));


                    TimeSlider.Visibility = Visibility.Visible;

                    TimeSpan ts = mediaPlayer.NaturalDuration.TimeSpan;

                    TimeSlider.Minimum = 0;
                    TimeSlider.Maximum = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                    TimeSlider.SmallChange = 1;
                    TimeSlider.LargeChange = Math.Min(10, ts.Seconds / 10);

                    TimeSlider.Value = mediaPlayer.Position.TotalSeconds;
                }

            }
            catch (Exception)
            {


            }

        }


        private void TimeSlider_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            _isDragging = true;
        }

        private void TimeSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            _isDragging = false;
            mediaPlayer.Position = TimeSpan.FromSeconds(TimeSlider.Value);
        }
    }
}
