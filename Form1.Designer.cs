
namespace musicPlay
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxVolum = new System.Windows.Forms.PictureBox();
            this.pictureBoxSvern = new System.Windows.Forms.PictureBox();
            this.pictureBox4Povtor = new System.Windows.Forms.PictureBox();
            this.pictureBoxPeremesh = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVpered = new System.Windows.Forms.PictureBox();
            this.pictureBoxNazad = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSvern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Povtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeremesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVpered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(222, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 263);
            this.panel1.TabIndex = 4;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Перетащите сюда музыку чтобы добавить";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.pictureBoxVolum);
            this.groupBox3.Controls.Add(this.pictureBoxSvern);
            this.groupBox3.Controls.Add(this.pictureBox4Povtor);
            this.groupBox3.Controls.Add(this.pictureBoxPeremesh);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBoxVpered);
            this.groupBox3.Controls.Add(this.pictureBoxNazad);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(221, 335);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(517, 136);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 20);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(512, 19);
            this.progressBar1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Текущий плейлист";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(206, 437);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сохраненные плейлисты:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::musicPlay.Properties.Resources.png_transparent_computer_icons_music_sound_k_song_miscellaneous_blue_text;
            this.pictureBox1.Location = new System.Drawing.Point(0, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave.Image")));
            this.pictureBoxSave.Location = new System.Drawing.Point(482, 26);
            this.pictureBoxSave.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(55, 36);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSave.TabIndex = 8;
            this.pictureBoxSave.TabStop = false;
            // 
            // pictureBoxVolum
            // 
            this.pictureBoxVolum.Image = global::musicPlay.Properties.Resources.volIcon;
            this.pictureBoxVolum.Location = new System.Drawing.Point(445, 48);
            this.pictureBoxVolum.Name = "pictureBoxVolum";
            this.pictureBoxVolum.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxVolum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVolum.TabIndex = 7;
            this.pictureBoxVolum.TabStop = false;
            // 
            // pictureBoxSvern
            // 
            this.pictureBoxSvern.Image = global::musicPlay.Properties.Resources.svernIcon;
            this.pictureBoxSvern.Location = new System.Drawing.Point(388, 48);
            this.pictureBoxSvern.Name = "pictureBoxSvern";
            this.pictureBoxSvern.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxSvern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSvern.TabIndex = 6;
            this.pictureBoxSvern.TabStop = false;
            // 
            // pictureBox4Povtor
            // 
            this.pictureBox4Povtor.Image = global::musicPlay.Properties.Resources.PovtorIcon;
            this.pictureBox4Povtor.Location = new System.Drawing.Point(334, 48);
            this.pictureBox4Povtor.Name = "pictureBox4Povtor";
            this.pictureBox4Povtor.Size = new System.Drawing.Size(48, 47);
            this.pictureBox4Povtor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4Povtor.TabIndex = 5;
            this.pictureBox4Povtor.TabStop = false;
            this.pictureBox4Povtor.Click += new System.EventHandler(this.pictureBox4Povtor_Click);
            // 
            // pictureBoxPeremesh
            // 
            this.pictureBoxPeremesh.Image = global::musicPlay.Properties.Resources.SmeshIcon1;
            this.pictureBoxPeremesh.Location = new System.Drawing.Point(277, 48);
            this.pictureBoxPeremesh.Name = "pictureBoxPeremesh";
            this.pictureBoxPeremesh.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxPeremesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPeremesh.TabIndex = 4;
            this.pictureBoxPeremesh.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::musicPlay.Properties.Resources.StartIcon;
            this.pictureBox3.Location = new System.Drawing.Point(84, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxVpered
            // 
            this.pictureBoxVpered.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVpered.Image")));
            this.pictureBoxVpered.Location = new System.Drawing.Point(141, 48);
            this.pictureBoxVpered.Name = "pictureBoxVpered";
            this.pictureBoxVpered.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxVpered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVpered.TabIndex = 2;
            this.pictureBoxVpered.TabStop = false;
            this.pictureBoxVpered.Click += new System.EventHandler(this.pictureBoxVpered_Click);
            // 
            // pictureBoxNazad
            // 
            this.pictureBoxNazad.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNazad.Image")));
            this.pictureBoxNazad.Location = new System.Drawing.Point(27, 48);
            this.pictureBoxNazad.Name = "pictureBoxNazad";
            this.pictureBoxNazad.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxNazad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNazad.TabIndex = 1;
            this.pictureBoxNazad.TabStop = false;
            this.pictureBoxNazad.Click += new System.EventHandler(this.pictureBoxNazad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSvern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Povtor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeremesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVpered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.PictureBox pictureBoxVolum;
        public System.Windows.Forms.PictureBox pictureBoxSvern;
        public System.Windows.Forms.PictureBox pictureBox4Povtor;
        public System.Windows.Forms.PictureBox pictureBoxPeremesh;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBoxVpered;
        public System.Windows.Forms.PictureBox pictureBoxNazad;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBoxSave;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

