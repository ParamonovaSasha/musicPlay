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
        //public delegate void PauseDelegate();

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public List<Thread> ListThread = new List<Thread>();

        public delegate void newsong();

        //Номер проигрываемой песни
        int song;

        //Высота одной панели
        int onepantop;

        //Повтор
        bool loop;

        //Пауза
        bool pause;

        //Перемешивание
        bool smesh;

        //Лист для песен в смешанном порядке
        List<string> filesmesh = new List<string>();

        //Путь до папки с песнями
        string newPath = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");

        //Лист для названий песен
        List<string> names = new List<string>();



        //Метод для выделения панели с играемой песней
        public void ColorChange(string number)
        {
            foreach (Panel pan in panel1.Controls.OfType<Panel>())
            {
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


        //Метод для смены песни в проигрыватели
        public void SongChange()
        {
           
            string[] files = Directory.GetFiles(newPath);

            if (smesh)
            {
                files = filesmesh.ToArray();
            }
      

            if (song < (files.Length - 1))
            {

                if (!loop)
                {

                    song++;
                    wplayer.URL = files[song];
                    wplayer.controls.play();

                }
                else
                {
                    //wplayer.URL = null;
                    wplayer.URL = files[song];
                    wplayer.controls.play();

                }
            }
        }


        //Метод, отрисовывавший панели с песнями на форме

        public void PrintSong()
        {
            //MessageBox.Show(names.Count.ToString());
            string[] files = Directory.GetFiles(newPath);
            panel1.Controls.Clear();
            onepantop = 0;

            for (int i = 0; i < files.Length; i++)
            {
                PictureBox[] pictureboxs = new PictureBox[2];
                Label labels = new Label();
                Panel pan = new Panel();

                int li = 0;
                int panHight = 0;
                int pantop = 5;


                if (i == song)
                {
                    pan.BackColor = Color.FromArgb(250, 250, 210);
                }


                pan.Name = i.ToString();
                pan.BorderStyle = BorderStyle.FixedSingle;

                if (names.Count == 1)
                {
                    pan.Top = 1 + 1 * 5;
                    pan.Width = 490;
                    pan.Height = 60;
                }
                else
                {
                    pan.Top = pantop + (onepantop * (i));
                    pan.Width = 490;
                    pan.Height = 60;
                }

               
                pictureboxs[li] = new PictureBox();
                
                Font font1 = new Font("Times New Roman", 12.0f,
                FontStyle.Regular);
                
                pictureboxs[li].Image = Properties.Resources.png_transparent_computer_icons_music_sound_k_song_miscellaneous_blue_text;

                pictureboxs[li].Top = 5 + 1 * 5;
                pictureboxs[li].Left = 20;
                pictureboxs[li].Height = 30;
                pictureboxs[li].Width = 30;
                pictureboxs[li].SizeMode = PictureBoxSizeMode.Zoom;


              
                labels = new Label();
                if (names[i].Length < 40)
                {
                    labels.Text = names[i];
                }
                else
                {
                    labels.Text = names[i].Substring(0, 39) + "....";
                }
                labels.Font = font1;


                labels.Top = 10 + 1 * 10;
                labels.Left = 80;
                labels.AutoSize = true;


                pictureboxs[li + 1] = new PictureBox();
                pictureboxs[li + 1].Name = li + 1.ToString();


                pictureboxs[li + 1].Top = 5 + 1 * 5;
                pictureboxs[li + 1].Left = 420;
                pictureboxs[li + 1].Height = 30;
                pictureboxs[li + 1].Width = 30;
                pictureboxs[li + 1].Image = Properties.Resources.krestik;
                pictureboxs[li + 1].SizeMode = PictureBoxSizeMode.Zoom;
                pictureboxs[li + 1].Click += SongDelete_Click;
                pictureboxs[li + 1].Name = i.ToString();

                panel1.Controls.Add(pan);
                pan.Controls.Add(pictureboxs[li]);
                pan.Controls.Add(labels);
                pan.Controls.Add(pictureboxs[li + 1]);
                pan.Click += Panel_Click;


                li += 2;
                if (i == 0)
                {
                    onepantop = pan.Height;
                }
            }
        }


        //Метод для запуска плайера в другом потоке
        public void  musicPlay()
        {
            string newPath = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");
            
            wplayer.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(WMP_PlayStateChange);
            wplayer.PlaylistChange += new _WMPOCXEvents_PlaylistChangeEventHandler(WMP_SongChange);

            //Считывание всех файлов из папки
            string[] files = Directory.GetFiles(newPath);
            wplayer.URL = files[song];


            //Событие смены у плейера свойства PlayState
            void WMP_PlayStateChange(int NewState)
            {
                //MessageBox.Show("Playstate сейчас = " + wplayer.playState.ToString());

                //Если медиа закончилось отрабатывается метод с запуском новой песни
                if (wplayer.playState == WMPPlayState.wmppsMediaEnded)
                {
                    //MessageBox.Show("Песня сменилась");
                    BeginInvoke(new newsong(SongChange));
                }
            }
                
            //Событие происходит при смене URL
            void WMP_SongChange(object Playlist, WMPPlaylistChangeEventType change)
            {
                if (wplayer.URL != null)
                {
                    //MessageBox.Show(Application.OpenForms.Count.ToString());
                    if (Application.OpenForms.Count == 2)
                    {
                        NewSong.EventHandler(names[song]);
                    }

                    BeginInvoke(new MyDelegate(ColorChange), song.ToString());
                    
                }

            }

        }

        public Form1()
        {
            InitializeComponent();

            PauseClass.EventHandler = new PauseClass.Pause(pictureBox3_Click);
            SmeshClass.EventHandler = new SmeshClass.Smesh(pictureBoxPeremesh_Click);
            VperedClass.EventHandler = new VperedClass.Vpered(pictureBoxVpered_Click);
            NazadClass.EventHandler = new NazadClass.Nazad(pictureBoxNazad_Click);
            LoopClass.EventHandler = new LoopClass.Loop(pictureBox4Povtor_Click);

            //ShowClass.EventHandler = new ShowClass.Show(Show);

            pause = true;
            loop = false;
            smesh = false;

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
                    string name = new System.IO.FileInfo(f).Name;

                    //Проверка формата заброшенного файла
                    if (!(names.Contains(name)))
                    {
                        allowfilesdrop = ((new System.IO.FileInfo(f)).Extension == ".mp3");
                    }


                    if (allowfilesdrop)
                    {
                        
                        if(!(names.Contains(name)))
                        {
                            //Добавление имени файла
                            names.Add(new System.IO.FileInfo(f).Name);
                        }
                        
                        path = Environment.CurrentDirectory;

                        string create = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");

                        string pathfile = new System.IO.FileInfo(f).FullName;

                        FileInfo fileInf = new FileInfo(pathfile);

                        

                        //MessageBox.Show(names.Count.ToString());

                        //Если это первая песня, то создается папка
                        if (names.Count == 1)
                        {
                            Directory.CreateDirectory(create);
                            label3.Text="";
                        }

                        //В папку копируется файл
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

                        //Если забрасываемая песня первая, то создается и запускается новый поток
                        if (names.Count == 1)
                        {
                            Thread myth = new Thread(musicPlay);
                            song = 0;
                            myth.Name = "Поток1";
                            myth.Start();
                            pictureBox3.Image = Properties.Resources.pauseIcon;
                            pause = false;
                        }
                    }

                }

                //Отрисовка 
                if (allowfilesdrop)
                {
                    PrintSong();
                }
            }
        }

        //При нажатии на панель с песней она включается
        private void Panel_Click(object sender, EventArgs e)
        {
            try
            {
                song = Convert.ToInt32((sender as Panel).Name);
                string[] files = Directory.GetFiles(newPath);
                files = Directory.GetFiles(newPath);
                wplayer.URL = files[song];
            }
            catch
            {

            }
        }

        //При нажатии кнопки удаления песня стирается с плейлиста и происходит перерисовка
        private void SongDelete_Click(object sender, EventArgs e)
        {
            
            int del= Convert.ToInt32((sender as PictureBox).Name);
            if (del != song)
            {
                string filename = Path.Combine(newPath, names[del]);
                File.Delete(filename);
                names.RemoveAt(del);

                if(del<song)
                {
                    song--;
                }

                PrintSong();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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

        //Пауза
        public void pictureBox3_Click()
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

        //Повтор
        public void pictureBox4Povtor_Click()
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

        //Следующая песня
        public void pictureBoxVpered_Click()
        {
            if (Directory.Exists(newPath))
            {
                string[] files = Directory.GetFiles(newPath);

                if (smesh)
                {
                    files = filesmesh.ToArray();
                }

                //Если далее есть еще песня, то она воспроизводится
                if (song < (files.Length - 1))
                {
                        song++;
                        wplayer.URL = files[song];
                }
            }
        }

        //Предыдущая песня
        public void pictureBoxNazad_Click()
        {
            if (Directory.Exists(newPath))
            {

                string[] files = Directory.GetFiles(newPath);

                if (smesh)
                {
                    files = filesmesh.ToArray();
                }

                if (song != 0)
                {
                    song--;
                    wplayer.URL = files[song];
                }
            }
        }

        //Перемешивание
        public void pictureBoxPeremesh_Click()
        {
            smesh = !smesh;
            string[] files = Directory.GetFiles(newPath);

            if (smesh)
            {
                names.Clear();
                pictureBoxPeremesh.Image = Properties.Resources.smeshwhite;
                Random random= new Random();

                for (int i = 0; i <files.Length; i++)
                {
                    if (i == song)
                    {
                        filesmesh.Add(files[i]);
 
                    }
                    else
                    {
                        int j = random.Next(0, files.Length);

                        while ((filesmesh.Contains(files[j])) || (files[j]==files[song]))
                        {
                            j = random.Next(0, (files.Length));
                        }
                        string pathsong = files[j];
                        filesmesh.Add(pathsong);
                        
                    }
                    string name = new System.IO.FileInfo(filesmesh[i]).Name;
                    names.Add(name);


                }

                PrintSong();
            }

            else
            {
                pictureBoxPeremesh.Image = Properties.Resources.SmeshIcon;
                filesmesh.Clear();
                names.Clear();

                foreach (string f in files)
                {
                    string name = new System.IO.FileInfo(f).Name;
                    names.Add(name);
                }

                PrintSong();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3_Click();
        }

        private void pictureBoxSvern_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.pause = pause;
            f2.peremesh = smesh;
            f2.loop = loop;
            f2.newPath = newPath;
            if (names.Count > 0)
            {
                NewSong.EventHandler(names[song]);
            }
            f2.Show();


        }

        private void pictureBoxNazad_Click(object sender, EventArgs e)
        {
            pictureBoxNazad_Click();
        }

        private void pictureBoxVpered_Click(object sender, EventArgs e)
        {
            pictureBoxVpered_Click();
        }

        private void pictureBoxPeremesh_Click(object sender, EventArgs e)
        {
            pictureBoxPeremesh_Click();
        }

        private void pictureBox4Povtor_Click(object sender, EventArgs e)
        {
            pictureBox4Povtor_Click();
        }


        private void pictureBoxClose_Click(object sender, EventArgs e)
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

            Close();
            Application.Exit();
        }
    }
}
