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
    public partial class Form2 : Form
    {

        public bool pause;
        public bool loop;
        public bool peremesh;
        public string newPath;

        public Form2()
        {
            NewSong.EventHandler = new NewSong.Song(ChangeLabel);
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PauseClass.EventHandler();

            if (Directory.Exists(newPath))
            {
                string[] files = Directory.GetFiles(newPath);
                if (files.Length != 0)
                {
                    pause = !pause;
                    if (pause)
                    {
                        pictureBox3.Image = Properties.Resources.StartIcon;
                    }
                    else
                    {
                        pictureBox3.Image = Properties.Resources.pauseIcon;
                    }
                }
            }
        }

        public void ChangeLabel(string nameSong)
        {
            //MessageBox.Show("Название изменено");
            NazvanLabel.Text = nameSong;
        }

        private void pictureBoxSvern_Click(object sender, EventArgs e)
        {
            
            //ShowClass.EventHandler();
            Form f = Application.OpenForms[0];
            f.Show();
            this.Close();
        }

        private void pictureBoxNazad_Click(object sender, EventArgs e)
        {
            NazadClass.EventHandler();
        }

        private void pictureBoxVpered_Click(object sender, EventArgs e)
        {
            VperedClass.EventHandler();
        }

        private void pictureBoxPeremesh_Click(object sender, EventArgs e)
        {
            SmeshClass.EventHandler();

            peremesh = !peremesh;
            string[] files = Directory.GetFiles(newPath);

            if (peremesh)
            {
                pictureBoxPeremesh.Image = Properties.Resources.smeshwhite;

            }

            else
            {
                pictureBoxPeremesh.Image = Properties.Resources.SmeshIcon;
            }
        }

        private void pictureBox4Povtor_Click(object sender, EventArgs e)
        {
            LoopClass.EventHandler();

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

        private void Form2_Load(object sender, EventArgs e)
        {
            if (peremesh)
            {
                pictureBoxPeremesh.Image = Properties.Resources.smeshwhite;

            }

            if (loop)
            {
                pictureBox4Povtor.Image = Properties.Resources.output_onlinepngtools__1_;
            }

            if (!pause)
            {
                pictureBox3.Image = Properties.Resources.pauseIcon;
            }
        }
    }
}
