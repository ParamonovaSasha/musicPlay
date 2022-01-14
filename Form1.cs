using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlay
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string>();

        public Form1()
        {
            InitializeComponent();

            //Подсказки при наведении на кнопки
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
                    //string[] strings = (string[])e.Data.GetData(DataFormats.FileDrop, true);

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
            string newPath = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");

            panel1.Controls.Clear();

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                foreach (string f in (string[])e.Data.GetData(DataFormats.FileDrop))
                {
                    allowfilesdrop = ((new System.IO.FileInfo(f)).Extension == ".mp3");

                    if (allowfilesdrop)
                    {

                        names.Add(new System.IO.FileInfo(f).Name);
                        path = Environment.CurrentDirectory;

                        string create = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");

                        if (names.Count == 1)
                        {
                            Directory.CreateDirectory(create);
                        }

                        string pathfile = new System.IO.FileInfo(f).FullName;


                        FileInfo fileInf = new FileInfo(pathfile);



                        if (fileInf.Exists)
                        {
                            File.Copy((pathfile), Path.Combine(newPath, names[names.Count - 1]), true);
                        }
                    }

                }

                if (allowfilesdrop)
                {
                    //Создания массива для создания картинок
                    PictureBox[] pictureboxs = new PictureBox[names.Count * 2];
                    Label[] labels = new Label[names.Count];
                    Panel[] pan = new Panel[names.Count];

                    int li = 0;
                    int panHight = 0;
                    int pantop = 5;

                    for (int i = 0; i < names.Count; i++)
                    {
                        //MessageBox.Show(names.Count.ToString());
                        //Создание панели
                        pan[i] = new Panel();
                        //pan[i].Name = "pan" + i.ToString();
                        pan[i].BorderStyle = BorderStyle.FixedSingle;

                        if (i == 0)
                        {
                            pan[i].Top = 1 + 1 * 5;
                            pan[i].Width = 490;
                            pan[i].Height = 60;


                        }
                        else
                        {
                            pan[i].Top = pantop + 5;
                            pan[i].Width = 490;
                            pan[i].Height = 60;
                        }

                        //Создание picturebox
                        pictureboxs[li] = new PictureBox();
                        pictureboxs[li].Name = "pic" + i;

                        //Создание шрифта
                        Font font1 = new Font("Times New Roman", 12.0f,
                        FontStyle.Regular);

                        //Вычисление положения pic на форме
                        pictureboxs[li].Top = 5 + 1 * 5;
                        pictureboxs[li].Left = 20;
                        pictureboxs[li].Height = 30;
                        pictureboxs[li].Width = 30;
                        pictureboxs[li].Image = Properties.Resources.p1_3103099_70c49ceb;
                        pictureboxs[li].SizeMode = PictureBoxSizeMode.Zoom;

                        //Создание labels
                        labels[i] = new Label();
                        if (names[i].Length < 40)
                        {
                            labels[i].Text = names[i];
                        }
                        else
                        {
                            labels[i].Text = names[i].Substring(0, 39) + "....";
                        }
                        labels[i].Font = font1;

                        //Вычисление положения label на форме
                        labels[i].Top = 10 + 1 * 10;
                        labels[i].Left = 80;
                        labels[i].AutoSize = true;

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

                        pantop += pan[i].Height;
                        panel1.Controls.Add(pan[i]);
                        pan[i].Controls.Add(pictureboxs[li]);
                        pan[i].Controls.Add(labels[i]);
                        pan[i].Controls.Add(pictureboxs[li + 1]);


                        li += 2;
                    }
                }

                string[] files = Directory.GetFiles(newPath);

                if (files.Length == 1)
                {
                    WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                    for (int k = 0; k < files.Length; k++)
                    {
                        //MessageBox.Show("true"+files[k]);
                        wplayer.URL = files[k];
                        wplayer.controls.play();
                    }

                }


            }
        }


        //Очистка плейлиста
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string newPath = Path.Combine(Directory.GetCurrentDirectory(), "Текущий плейлист");
            Directory.Delete(newPath, true);
        }
    }
}
