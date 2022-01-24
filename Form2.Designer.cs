
namespace musicPlay
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label2 = new System.Windows.Forms.Label();
            this.NazvanLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxSvern = new System.Windows.Forms.PictureBox();
            this.pictureBox4Povtor = new System.Windows.Forms.PictureBox();
            this.pictureBoxPeremesh = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVpered = new System.Windows.Forms.PictureBox();
            this.pictureBoxNazad = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSvern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4Povtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeremesh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVpered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNazad)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сейчас играет:";
            // 
            // NazvanLabel
            // 
            this.NazvanLabel.AutoSize = true;
            this.NazvanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NazvanLabel.Location = new System.Drawing.Point(129, 9);
            this.NazvanLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NazvanLabel.Name = "NazvanLabel";
            this.NazvanLabel.Size = new System.Drawing.Size(83, 20);
            this.NazvanLabel.TabIndex = 5;
            this.NazvanLabel.Text = "Название";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.pictureBoxSvern);
            this.groupBox3.Controls.Add(this.pictureBox4Povtor);
            this.groupBox3.Controls.Add(this.pictureBoxPeremesh);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBoxVpered);
            this.groupBox3.Controls.Add(this.pictureBoxNazad);
            this.groupBox3.Location = new System.Drawing.Point(5, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(516, 102);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // pictureBoxSvern
            // 
            this.pictureBoxSvern.Image = global::musicPlay.Properties.Resources.svernIcon;
            this.pictureBoxSvern.Location = new System.Drawing.Point(414, 17);
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
            this.pictureBox4Povtor.Location = new System.Drawing.Point(360, 18);
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
            this.pictureBoxPeremesh.Location = new System.Drawing.Point(303, 18);
            this.pictureBoxPeremesh.Name = "pictureBoxPeremesh";
            this.pictureBoxPeremesh.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxPeremesh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPeremesh.TabIndex = 4;
            this.pictureBoxPeremesh.TabStop = false;
            this.pictureBoxPeremesh.Click += new System.EventHandler(this.pictureBoxPeremesh_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(84, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxVpered
            // 
            this.pictureBoxVpered.Image = global::musicPlay.Properties.Resources.NextIcon;
            this.pictureBoxVpered.Location = new System.Drawing.Point(141, 18);
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
            this.pictureBoxNazad.Location = new System.Drawing.Point(27, 18);
            this.pictureBoxNazad.Name = "pictureBoxNazad";
            this.pictureBoxNazad.Size = new System.Drawing.Size(51, 47);
            this.pictureBoxNazad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNazad.TabIndex = 1;
            this.pictureBoxNazad.TabStop = false;
            this.pictureBoxNazad.Click += new System.EventHandler(this.pictureBoxNazad_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 107);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.NazvanLabel);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "MP3Player";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox3.ResumeLayout(false);
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

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label NazvanLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxSvern;
        private System.Windows.Forms.PictureBox pictureBox4Povtor;
        private System.Windows.Forms.PictureBox pictureBoxPeremesh;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxVpered;
        private System.Windows.Forms.PictureBox pictureBoxNazad;
    }
}