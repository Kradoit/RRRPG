namespace RRRPG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGame));
            btnDoIt = new Button();
            label3 = new Label();
            btnStart = new Button();
            tmrStateMachine = new System.Windows.Forms.Timer(components);
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            lblOpponent2 = new Label();
            picOpponent2 = new PictureBox();
            lblPlayer = new Label();
            lblOpponent = new Label();
            picPlayer = new PictureBox();
            picOpponent = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            SuspendLayout();
            // 
            // picOpponent
            // 
            picOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent.Location = new Point(1398, 356);
            picOpponent.Margin = new Padding(7, 8, 7, 8);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(1071, 1156);
            picOpponent.TabIndex = 28;
            picOpponent.TabStop = false;
            // 
            // btnDoIt
            // 
            btnDoIt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoIt.Location = new Point(355, 1414);
            btnDoIt.Margin = new Padding(7, 8, 7, 8);
            btnDoIt.Name = "btnDoIt";
            btnDoIt.Size = new Size(546, 192);
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
            btnStart.Margin = new Padding(5);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(128, 38);
            btnStart.TabIndex = 11;
            // 
            // tmrStateMachine
            // 
            tmrStateMachine.Interval = 40;
            tmrStateMachine.Tick += tmrDialog_Tick;
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
            lblOpponent2.Location = new Point(2931, 272);
            lblOpponent2.Margin = new Padding(5, 0, 5, 0);
            lblOpponent2.Name = "lblOpponent2";
            lblOpponent2.Size = new Size(0, 81);
            lblOpponent2.TabIndex = 33;
            // 
            // picOpponent2
            // 
            this.picOpponent2.BackgroundImageLayout = ImageLayout.Stretch;
            this.picOpponent2.Location = new Point(2617, 420);
            this.picOpponent2.Margin = new Padding(7, 8, 7, 8);
            this.picOpponent2.Name = "picOpponent2";
            this.picOpponent2.Size = new Size(993, 1058);
            this.picOpponent2.TabIndex = 32;
            this.picOpponent2.TabStop = false;
            this.picOpponent2.Click += this.pictureBox1_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = Color.White;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.Location = new Point(156, 214);
            lblPlayer.Margin = new Padding(7, 0, 7, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(0, 81);
            lblPlayer.TabIndex = 31;
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.BackColor = Color.White;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.Location = new Point(1686, 223);
            lblOpponent.Margin = new Padding(5, 0, 5, 0);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(0, 81);
            lblOpponent.TabIndex = 30;
            // 
            // picPlayer
            // 
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Image = Properties.Resources.Img_Bender_Idle;
            picPlayer.Location = new Point(48, 356);
            picPlayer.Margin = new Padding(7, 8, 7, 8);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(1122, 936);
            picPlayer.TabIndex = 29;
            picPlayer.TabStop = false;
            // 
            // mainGame
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(3244, 2108);
            Controls.Add(lblOpponent2);
            Controls.Add(picOpponent2);
            Controls.Add(lblPlayer);
            Controls.Add(lblOpponent);
            Controls.Add(picPlayer);
            Controls.Add(picOpponent);
            Controls.Add(btnStart);
            Controls.Add(btnDoIt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(7, 8, 7, 8);
            Name = "mainGame";
            Text = "Russian Roulette RPG";
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDoIt;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrStateMachine;
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
    }
}