﻿namespace RRRPG
{
    partial class FrmTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTitle));
            btnPlay = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.BackgroundImage = Properties.Resources.Img_Title_Play_Button;
            btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.FlatStyle = FlatStyle.Popup;
            btnPlay.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlay.ForeColor = Color.Black;
            btnPlay.Location = new Point(124, 1228);
            btnPlay.Margin = new Padding(7, 8, 7, 8);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(672, 208);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Singleplayer";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Img_Title_Play_Button;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(189, 1453);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(607, 208);
            button1.TabIndex = 1;
            button1.Text = "Multiplayer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox1.BackgroundImage = Properties.Resources.gears;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(2334, 136);
            pictureBox1.Margin = new Padding(5, 5, 5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 282);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += buttonSettings_Click;
            // 
            // FrmTitle
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Img_Title;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2718, 2108);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnPlay);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 8, 7, 8);
            Name = "FrmTitle";
            Text = "Russian Roulette RPG";
            FormClosed += FrmTitle_FormClosed;
            Load += FrmTitle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button button1;
        private PictureBox pictureBox1;
    }
}