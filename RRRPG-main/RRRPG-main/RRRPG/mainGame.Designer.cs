﻿namespace RRRPG
{
    partial class mainGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PictureBox picOpponent;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGame));
            btnDoIt = new Button();
            label3 = new Label();
            btnStart = new Button();
            tmrStateMachine = new System.Windows.Forms.Timer(components);
            tmrMultiplayer = new System.Windows.Forms.Timer(components);
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            lblOpponent2 = new Label();
            picOpponent2 = new PictureBox();
            lblPlayer = new Label();
            lblOpponent = new Label();
            picPlayer = new PictureBox();
            name1 = new Label();
            playerName = new Label();
            name2 = new Label();
            picOpponent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            SuspendLayout();
            // 
            // btnDoIt
            // 
            btnDoIt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoIt.Location = new Point(209, 862);
            btnDoIt.Margin = new Padding(4, 5, 4, 5);
            btnDoIt.Name = "btnDoIt";
            btnDoIt.Size = new Size(321, 117);
            btnDoIt.TabIndex = 2;
            btnDoIt.Text = "Try Your Luck!";
            btnDoIt.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDoIt.UseVisualStyleBackColor = true;
            btnDoIt.Click += btnDoIt_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(294, 325);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(241, 45);
            label3.TabIndex = 11;
            label3.Text = "Weapon Select";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(0, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 11;
            // 
            // tmrStateMachine
            // 
            tmrStateMachine.Interval = 40;
            tmrStateMachine.Tick += tmrDialog_Tick;
            // 
            // tmrMultiplayer
            // 
            tmrMultiplayer.Interval = 40;
            tmrMultiplayer.Tick += multiPlayerLoop;
            // 
            // tmrPlayMusicAfterGameOver
            // 
            tmrPlayMusicAfterGameOver.Interval = 2000;
            tmrPlayMusicAfterGameOver.Tick += tmrPlayMusicAfterGameOver_Tick;
            // 
            // lblOpponent2
            // 
            lblOpponent2.AutoSize = true;
            lblOpponent2.BackColor = Color.White;
            lblOpponent2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent2.Location = new Point(1724, 166);
            lblOpponent2.Name = "lblOpponent2";
            lblOpponent2.Size = new Size(0, 48);
            lblOpponent2.TabIndex = 33;
            // 
            // picOpponent2
            // 
            picOpponent2.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent2.Location = new Point(1539, 256);
            picOpponent2.Margin = new Padding(4, 5, 4, 5);
            picOpponent2.Name = "picOpponent2";
            picOpponent2.Size = new Size(584, 645);
            picOpponent2.TabIndex = 32;
            picOpponent2.TabStop = false;
            picOpponent2.Click += pictureBox1_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = Color.White;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.Location = new Point(92, 130);
            lblPlayer.Margin = new Padding(4, 0, 4, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(0, 48);
            lblPlayer.TabIndex = 31;
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.BackColor = Color.White;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.Location = new Point(992, 136);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(0, 48);
            lblOpponent.TabIndex = 30;
            // 
            // picPlayer
            // 
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Image = Properties.Resources.Img_Bender_Idle;
            picPlayer.Location = new Point(28, 217);
            picPlayer.Margin = new Padding(4, 5, 4, 5);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(660, 571);
            picPlayer.TabIndex = 29;
            picPlayer.TabStop = false;
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.BackColor = Color.White;
            name1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            name1.ForeColor = Color.Black;
            name1.Location = new Point(1040, 13);
            name1.Margin = new Padding(2, 0, 2, 0);
            name1.Name = "name1";
            name1.Size = new Size(0, 54);
            name1.TabIndex = 34;
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.BackColor = Color.White;
            playerName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.Black;
            playerName.Location = new Point(288, 5);
            playerName.Margin = new Padding(2, 0, 2, 0);
            playerName.Name = "playerName";
            playerName.Size = new Size(87, 54);
            playerName.TabIndex = 35;
            playerName.Text = "You";
            // 
            // name2
            // 
            name2.AutoSize = true;
            name2.BackColor = Color.White;
            name2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            name2.ForeColor = Color.Black;
            name2.Location = new Point(1685, 30);
            name2.Margin = new Padding(2, 0, 2, 0);
            name2.Name = "name2";
            name2.Size = new Size(0, 54);
            name2.TabIndex = 36;
            // 
            // picOpponent
            // 
            picOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent.Location = new Point(822, 217);
            picOpponent.Margin = new Padding(4, 5, 4, 5);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(630, 705);
            picOpponent.TabIndex = 28;
            picOpponent.TabStop = false;
            // 
            // mainGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1784, 1341);
            Controls.Add(name2);
            Controls.Add(playerName);
            Controls.Add(name1);
            Controls.Add(lblOpponent2);
            Controls.Add(picOpponent2);
            Controls.Add(lblPlayer);
            Controls.Add(lblOpponent);
            Controls.Add(picPlayer);
            Controls.Add(picOpponent);
            Controls.Add(btnStart);
            Controls.Add(btnDoIt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "mainGame";
            Text = "Russian Roulette RPG";
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picOpponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDoIt;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrStateMachine;
        private System.Windows.Forms.Timer tmrMultiplayer;
        private Label label3;
        private Label lblWeaponSelectBow;
        private Label lblWeaponSelectNerfRev;
        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private PictureBox picOpponent2;
        private Label lblOpponent2;
        private Label lblPlayer;
        private Label lblOpponent;
        private PictureBox picPlayer;
        private PictureBox picOpponent;
        private Label name1;
        private Label playerName;
        private Label name2;
    }
}