using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace musicPlay
{
    
    public partial class Form1 : Form
    {
        public delegate void MyDelegate(string number);

        

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public List<Thread> ListThread= new List<Thread>();
        public delegate void DeigateSong();
        
        int song;

        int onepantop;

        bool loop;

        bool pause;

        public void ColorChange(string number)
        {
            //MessageBox.Show("Я попал в метод");

            foreach (Panel pan in panel1.Controls.OfType<Panel>())
            {
                //MessageBox.Show("Имя панели=" + pan.Name+ "Искомое имя "+number);
                if (pan.Name == number)
                {
                    pan.BackColor = Color.FromArgb(250, 250, 210);
                }
                else
                {
                    pan.BackColor = Color.White;
                }

            }
        }

        string newPath = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");


        public void  musicPlay()
        {
            string newPath = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");
            
            wplayer.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(WMP_PlayStateChange);
            wplayer.PlaylistChange += new _WMPOCXEvents_PlaylistChangeEventHandler(WMP_SongChange);
            string[] files = Directory.GetFiles(newPath);

            files = Directory.GetFiles(newPath);
            wplayer.URL = files[song];

           
            void WMP_PlayStateChange(int NewState)
            {
                //MessageBox.Show("Playstate сейчас = " + wplayer.playState.ToString());

                files = Directory.GetFiles(newPath);

                if (wplayer.playState == WMPPlayState.wmppsStopped)
                {
                    if (song < (files.Length - 1))
                    {
                        //MessageBox.Show("Я здесь, песня номер"+song);
                        if (!loop)
                        {
                            song++;
                            wplayer.URL = files[song];
                        }
                        else
                        {
                            wplayer.URL = null;
                            wplayer.URL = files[song];
                        }
                        
                       
                        
                    }
                }

            }

            void WMP_SongChange(object Playlist, WMPPlaylistChangeEventType change)
            {
                if (wplayer.URL != null)
                {
                    //MessageBox.Show("Музыка изменена");

                    BeginInvoke(new MyDelegate(ColorChange), song.ToString());
                    wplayer.controls.play();
                }
                //song++;
            }

        }

       

        List<string> names = new List<string>();


        public Form1()
        {
            InitializeComponent();

            
            pause = true;
            loop = false;
            //Подсказки при наведении на кнопки

            ToolTip t1 = new ToolTip();
            t1.SetToolTip(pictureBoxNazad, "Предыдущая песня");

            ToolTip t2 = new ToolTip();
            t2.SetToolTip(pictureBox4Povtor, "Повтор песни");

            ToolTip t3 = new ToolTip();
            t3.SetToolTip(pictureBoxPeremesh, "Воcпроизведение в произвольном порядке");


            ToolTip t4 = new ToolTip();
            t4.SetToolTip(pictureBoxSvern, "Свернуть");

            ToolTip t5 = new ToolTip();
            t5.SetToolTip(pictureBoxSave, "Сохранить текущий плейлист");

            ToolTip t6 = new ToolTip();
            t6.SetToolTip(pictureBoxVolum, "Изменить уровень громкости");

            ToolTip t7 = new ToolTip();
            t7.SetToolTip(pictureBoxVpered, "Следующая песня");

        }


        private void panel1_DragEnter(object sender, DragEventArgs e)
        {

            bool allowfilesdrop = false;


            //Проверка формата аудеозаписи
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                foreach (string f in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    allowfilesdrop = ((new System.IO.FileInfo(f)).Extension == ".mp3");
                }

                if (allowfilesdrop)
                {


                    e.Effect = DragDropEffects.Copy;
                   
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }


        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

            bool allowfilesdrop = false;
            string path;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                foreach (string f in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    allowfilesdrop = ((new System.IO.FileInfo(f)).Extension == ".mp3");

                    if (allowfilesdrop)
                    {

                        //Добавление имени файла
                        names.Add(new System.IO.FileInfo(f).Name);
                        path = Environment.CurrentDirectory;

                        string create = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");

                        string pathfile = new System.IO.FileInfo(f).FullName;

                        FileInfo fileInf = new FileInfo(pathfile);

                        

                        //MessageBox.Show(names.Count.ToString());

                        if (names.Count == 1)
                        {
                            Directory.CreateDirectory(create);
                            label3.Text="";
                        }

                        if (fileInf.Exists)
                        {
                            try
                            {
                                File.Copy((pathfile), Path.Combine(newPath, names[names.Count - 1]), true);
                            }
                            catch
                            {

                            }
                            
                        }

                        if (names.Count == 1)
                        {
                            Thread myth = new Thread(musicPlay);
                            song = 0;
                            myth.Name = "Поток1";
                            ListThread.Add(myth);
                            myth.Start();
                            pictureBox3.Image = Properties.Resources.pauseIcon;
                            pause = false;
                        }
                    }

                }

                if (allowfilesdrop)
                {
                    
                    //Создания массива для создания картинок
                    PictureBox[] pictureboxs = new PictureBox[2];
                    Label labels = new Label();
                    Panel pan = new Panel();
                  
                    int li = 0;
                    int panHight = 0;
                    int pantop = 5;
                    

                        //Создание панели
                        pan = new Panel();
                        pan.Name = (names.Count-1).ToString();
                        //pan[i].Name = "pan" + i.ToString();
                        pan.BorderStyle = BorderStyle.FixedSingle;

                        if (names.Count == 1)
                        {
                            pan.Top = 1 + 1 * 5;
                            pan.Width = 490;
                            pan.Height = 60;
                        }
                        else
                        {
                            pan.Top = pantop+(onepantop*(names.Count-1));
                            pan.Width = 490;
                            pan.Height = 60;
                        }
                        
                        //Создание picturebox
                        pictureboxs[li] = new PictureBox();
                        pictureboxs[li].Name = (names.Count-1).ToString();


                        //Создание шрифта
                        Font font1 = new Font("Times New Roman", 12.0f,
                        FontStyle.Regular);
                        //MessageBox.Show("2");
                        pictureboxs[li].Image = Properties.Resources.png_transparent_computer_icons_music_sound_k_song_miscellaneous_blue_text;

                        //Вычисление положения pic на форме
                        pictureboxs[li].Top = 5 + 1 * 5;
                        pictureboxs[li].Left = 20;
                        pictureboxs[li].Height = 30; 
                        pictureboxs[li].Width = 30;
                        pictureboxs[li].SizeMode = PictureBoxSizeMode.Zoom;
                        

                        //Создание labels
                        labels = new Label();
                        if (names[(names.Count-1)].Length < 40)
                        {
                            labels.Text = names[(names.Count - 1)];
                        }
                        else
                        {
                            labels.Text = names[(names.Count - 1)].Substring(0, 39) + "....";
                        }
                        labels.Font = font1;

                        //Вычисление положения label на форме
                        labels.Top = 10 + 1 * 10;
                        labels.Left = 80;
                        labels.AutoSize = true;

                        //Создание кнопки удалить
                        //Создание picturebox
                        pictureboxs[li + 1] = new PictureBox();
                        pictureboxs[li + 1].Name = li + 1.ToString();

                        //Вычисление положения pic на форме
                        pictureboxs[li + 1].Top = 5 + 1 * 5;
                        pictureboxs[li + 1].Left = 420;
                        pictureboxs[li + 1].Height = 30;
                        pictureboxs[li + 1].Width = 30;
                        pictureboxs[li + 1].Image = Properties.Resources.volIcon;
                        pictureboxs[li + 1].SizeMode = PictureBoxSizeMode.Zoom;

                        
                        panel1.Controls.Add(pan);
                        pan.Controls.Add(pictureboxs[li]);
                        pan.Controls.Add(labels);
                        pan.Controls.Add(pictureboxs[li + 1]);
                        pan.Click += Panel_Click;


                    li += 2;
                        if (names.Count == 1)
                        {
                            onepantop = pan.Height;
                        }
                    //MessageBox.Show("Все еще здесь");


                }
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            
            song=Convert.ToInt32((sender as Panel).Name);
            MessageBox.Show(song.ToString());
            MessageBox.Show("Песня запущена");
            string[] files = Directory.GetFiles(newPath);
            files = Directory.GetFiles(newPath);
            wplayer.URL = files[song];
        }

        //Очистка плейлиста
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string newPath = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");
            try
            {
                if (Directory.Exists(newPath))
                {
                    Directory.Delete(newPath, true);
                }
            }
            catch
            {

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string newPath = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");

            if (Directory.Exists(newPath))
            {
                Directory.Delete(newPath, true);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(newPath))
            {
                string[] files = Directory.GetFiles(newPath);
                if (files.Length != 0)
                {
                    pause = !pause;
                    if (pause)
                    {
                        pictureBox3.Image = Properties.Resources.StartIcon;
                        wplayer.controls.pause();
                    }
                    else
                    {
                        pictureBox3.Image = Properties.Resources.pauseIcon;
                        wplayer.controls.play();
                    }
                }
            }
        }

        private void pictureBox4Povtor_Click(object sender, EventArgs e)
        {
            loop = !loop;
            if (loop)
            {
                pictureBox4Povtor.Image = Properties.Resources.output_onlinepngtools__1_;
            }
            else
            {
                pictureBox4Povtor.Image = Properties.Resources.PovtorIcon;
            }
        }

        private void pictureBoxVpered_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(newPath))
            {
                string[] files = Directory.GetFiles(newPath);

                if (song < (files.Length - 1))
                {

                    if (!loop)
                    {
                        song++;
                        wplayer.URL = files[song];
                    }

                }
            }
        }

        private void pictureBoxNazad_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(newPath))
            {
                string[] files = Directory.GetFiles(newPath);

                if (song != 0)
                {
                    song--;
                    wplayer.URL = files[song];
                }
            }
        }
    }
}
