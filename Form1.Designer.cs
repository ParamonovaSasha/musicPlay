
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
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3TimeSong = new System.Windows.Forms.Panel();
            this.pictureBoxPolz = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSvern = new System.Windows.Forms.PictureBox();
            this.pictureBox4Povtor = new System.Windows.Forms.PictureBox();
            this.pictureBoxPeremesh = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVpered = new System.Windows.Forms.PictureBox();
            this.pictureBoxNazad = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSozd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3TimeSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSvern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Povtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeremesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVpered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label31);
            this.panel1.Location = new System.Drawing.Point(222, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 256);
            this.panel1.TabIndex = 4;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(79, 104);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(335, 20);
            this.label31.TabIndex = 2;
            this.label31.Text = "Перетащите сюда музыку чтобы добавить";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.panel3TimeSong);
            this.groupBox3.Controls.Add(this.pictureBoxSvern);
            this.groupBox3.Controls.Add(this.pictureBox4Povtor);
            this.groupBox3.Controls.Add(this.pictureBoxPeremesh);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBoxVpered);
            this.groupBox3.Controls.Add(this.pictureBoxNazad);
            this.groupBox3.Location = new System.Drawing.Point(221, 341);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(512, 109);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // panel3TimeSong
            // 
            this.panel3TimeSong.Controls.Add(this.pictureBoxPolz);
            this.panel3TimeSong.Controls.Add(this.pictureBox2);
            this.panel3TimeSong.Location = new System.Drawing.Point(33, 8);
            this.panel3TimeSong.Name = "panel3TimeSong";
            this.panel3TimeSong.Size = new System.Drawing.Size(450, 22);
            this.panel3TimeSong.TabIndex = 7;
            // 
            // pictureBoxPolz
            // 
            this.pictureBoxPolz.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPolz.Image")));
            this.pictureBoxPolz.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPolz.Name = "pictureBoxPolz";
            this.pictureBoxPolz.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxPolz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPolz.TabIndex = 1;
            this.pictureBoxPolz.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // pictureBoxSvern
            // 
            this.pictureBoxSvern.Image = global::musicPlay.Properties.Resources.svernIcon;
            this.pictureBoxSvern.Location = new System.Drawing.Point(422, 36);
            this.pictureBoxSvern.Name = "pictureBoxSvern";
            this.pictureBoxSvern.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxSvern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSvern.TabIndex = 6;
            this.pictureBoxSvern.TabStop = false;
            this.pictureBoxSvern.Click += new System.EventHandler(this.pictureBoxSvern_Click);
            // 
            // pictureBox4Povtor
            // 
            this.pictureBox4Povtor.Image = global::musicPlay.Properties.Resources.PovtorIcon;
            this.pictureBox4Povtor.Location = new System.Drawing.Point(368, 36);
            this.pictureBox4Povtor.Name = "pictureBox4Povtor";
            this.pictureBox4Povtor.Size = new System.Drawing.Size(48, 47);
            this.pictureBox4Povtor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4Povtor.TabIndex = 5;
            this.pictureBox4Povtor.TabStop = false;
            this.pictureBox4Povtor.Click += new System.EventHandler(this.pictureBox4Povtor_Click);
            // 
            // pictureBoxPeremesh
            // 
            this.pictureBoxPeremesh.Image = global::musicPlay.Properties.Resources.SmeshIcon;
            this.pictureBoxPeremesh.Location = new System.Drawing.Point(311, 36);
            this.pictureBoxPeremesh.Name = "pictureBoxPeremesh";
            this.pictureBoxPeremesh.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxPeremesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPeremesh.TabIndex = 4;
            this.pictureBoxPeremesh.TabStop = false;
            this.pictureBoxPeremesh.Click += new System.EventHandler(this.pictureBoxPeremesh_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::musicPlay.Properties.Resources.StartIcon;
            this.pictureBox3.Location = new System.Drawing.Point(84, 36);
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
            this.pictureBoxVpered.Location = new System.Drawing.Point(141, 36);
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
            this.pictureBoxNazad.Location = new System.Drawing.Point(33, 36);
            this.pictureBoxNazad.Name = "pictureBoxNazad";
            this.pictureBoxNazad.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxNazad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNazad.TabIndex = 1;
            this.pictureBoxNazad.TabStop = false;
            this.pictureBoxNazad.Click += new System.EventHandler(this.pictureBoxNazad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Новый плейлист";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.buttonSozd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(206, 444);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(8, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 285);
            this.panel2.TabIndex = 4;
            // 
            // buttonSozd
            // 
            this.buttonSozd.BackColor = System.Drawing.SystemColors.Info;
            this.buttonSozd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSozd.Location = new System.Drawing.Point(-1, 96);
            this.buttonSozd.Name = "buttonSozd";
            this.buttonSozd.Size = new System.Drawing.Size(206, 32);
            this.buttonSozd.TabIndex = 3;
            this.buttonSozd.Text = "Создать ноый плейлист +";
            this.buttonSozd.UseVisualStyleBackColor = false;
            this.buttonSozd.Click += new System.EventHandler(this.buttonSozd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 131);
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
            this.pictureBox1.Size = new System.Drawing.Size(193, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave.Image")));
            this.pictureBoxSave.Location = new System.Drawing.Point(305, 11);
            this.pictureBoxSave.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(55, 36);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSave.TabIndex = 8;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.pictureBoxSave_Click);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(678, 6);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(55, 36);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 10;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClear.Image")));
            this.pictureBoxClear.Location = new System.Drawing.Point(394, 11);
            this.pictureBoxClear.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(55, 36);
            this.pictureBoxClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClear.TabIndex = 11;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.Click += new System.EventHandler(this.pictureBoxClear_Click);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDelete.Image")));
            this.pictureBoxDelete.Location = new System.Drawing.Point(474, 11);
            this.pictureBoxDelete.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(56, 36);
            this.pictureBoxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDelete.TabIndex = 12;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 453);
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.pictureBoxClear);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel3TimeSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSvern)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Povtor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeremesh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVpered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label31;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.PictureBox pictureBoxSvern;
        public System.Windows.Forms.PictureBox pictureBox4Povtor;
        public System.Windows.Forms.PictureBox pictureBoxPeremesh;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBoxVpered;
        public System.Windows.Forms.PictureBox pictureBoxNazad;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBoxSave;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Button buttonSozd;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBoxClear;
        public System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.Panel panel3TimeSong;
        private System.Windows.Forms.PictureBox pictureBoxPolz;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

