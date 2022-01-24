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
    public partial class Form3 : Form
    {
        string newPath = Path.Combine(Directory.GetCurrentDirectory(), "Плейлисты");

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxNazvanie.Text.Length==0)
            {
                MessageBox.Show("Введите название плейлиста");
            }
            else
            {
                if(Directory.Exists(Path.Combine(newPath, textBoxNazvanie.Text)))
                {
                    MessageBox.Show("Плейлист с таким названием уже существует, введите другое");
                }
                else
                {
                    
                    PlaylistClass.EventHandler(textBoxNazvanie.Text);
                    this.Close();
                    
                }
            }
            
        }
    }
}
