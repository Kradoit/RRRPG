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
            btnPlay.Location = new Point(73, 774);
            btnPlay.Margin = new Padding(4, 5, 4, 5);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(336, 127);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "PlayV1";
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
            button1.Location = new Point(111, 928);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(336, 127);
            button1.TabIndex = 1;
            button1.Text = "PlayV2";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmTitle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Img_Title;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1400, 1208);
            Controls.Add(button1);
            Controls.Add(btnPlay);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmTitle";
            Text = "Russian Roulette RPG";
            FormClosed += FrmTitle_FormClosed;
            Load += FrmTitle_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button button1;
    }
}