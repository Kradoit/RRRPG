﻿namespace RRRPG
{
    partial class settings
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
            label1 = new Label();
            buttonBack = new Button();
            buttonTrack1 = new Button();
            buttonTrack2 = new Button();
            buttonTrack3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(446, 97);
            label1.Name = "label1";
            label1.Size = new Size(195, 67);
            label1.TabIndex = 0;
            label1.Text = "Volume";
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(128, 579);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(207, 118);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonTrack1
            // 
            buttonTrack1.Location = new Point(478, 189);
            buttonTrack1.Name = "buttonTrack1";
            buttonTrack1.Size = new Size(112, 34);
            buttonTrack1.TabIndex = 4;
            buttonTrack1.Text = "Track1";
            buttonTrack1.UseVisualStyleBackColor = true;
            buttonTrack1.Click += buttonTrack1_Click;
            // 
            // buttonTrack2
            // 
            buttonTrack2.Location = new Point(478, 243);
            buttonTrack2.Name = "buttonTrack2";
            buttonTrack2.Size = new Size(112, 34);
            buttonTrack2.TabIndex = 5;
            buttonTrack2.Text = "Track2";
            buttonTrack2.UseVisualStyleBackColor = true;
            buttonTrack2.Click += buttonTrack2_Click;
            // 
            // buttonTrack3
            // 
            buttonTrack3.Location = new Point(478, 294);
            buttonTrack3.Name = "buttonTrack3";
            buttonTrack3.Size = new Size(112, 34);
            buttonTrack3.TabIndex = 6;
            buttonTrack3.Text = "Track3";
            buttonTrack3.UseVisualStyleBackColor = true;
            buttonTrack3.Click += buttonTrack3_Click;
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1489, 801);
            Controls.Add(buttonTrack3);
            Controls.Add(buttonTrack2);
            Controls.Add(buttonTrack1);
            Controls.Add(buttonBack);
            Controls.Add(label1);
            Name = "settings";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonBack;
        private Button buttonTrack1;
        private Button buttonTrack2;
        private Button buttonTrack3;
    }
}