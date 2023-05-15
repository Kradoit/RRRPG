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
            tmrStateMachine = new System.Windows.Forms.Timer(components);
            tmrMultiplayer = new System.Windows.Forms.Timer(components);
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            lblPlayer = new Label();
            lblOpponent = new Label();
            name1 = new Label();
            playerName = new Label();
            name2 = new Label();
            picOpponent2 = new PictureBox();
            picPlayer = new PictureBox();
            picOpponent = new PictureBox();
            lblOpponent2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            SuspendLayout();
            // 
            // btnDoIt
            // 
            btnDoIt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoIt.Location = new Point(170, 1220);
            btnDoIt.Margin = new Padding(6, 8, 6, 8);
            btnDoIt.Name = "btnDoIt";
            btnDoIt.Size = new Size(546, 193);
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
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = Color.White;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.Location = new Point(155, 213);
            lblPlayer.Margin = new Padding(6, 0, 6, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(0, 81);
            lblPlayer.TabIndex = 31;
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.BackColor = Color.White;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.Location = new Point(1258, 252);
            lblOpponent.Margin = new Padding(4, 0, 4, 0);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(0, 81);
            lblOpponent.TabIndex = 30;
            // 
            // name1
            // 
            name1.AutoSize = true;
            name1.BackColor = Color.White;
            name1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            name1.ForeColor = Color.Black;
            name1.Location = new Point(1456, 55);
            name1.Margin = new Padding(2, 0, 2, 0);
            name1.Name = "name1";
            name1.Size = new Size(0, 89);
            name1.TabIndex = 34;
            // 
            // playerName
            // 
            playerName.AutoSize = true;
            playerName.BackColor = Color.White;
            playerName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            playerName.ForeColor = Color.Black;
            playerName.Location = new Point(382, 55);
            playerName.Margin = new Padding(2, 0, 2, 0);
            playerName.Name = "playerName";
            playerName.Size = new Size(146, 89);
            playerName.TabIndex = 35;
            playerName.Text = "You";
            // 
            // name2
            // 
            name2.AutoSize = true;
            name2.BackColor = Color.White;
            name2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            name2.ForeColor = Color.Black;
            name2.Location = new Point(2520, 37);
            name2.Margin = new Padding(2, 0, 2, 0);
            name2.Name = "name2";
            name2.Size = new Size(0, 89);
            name2.TabIndex = 36;
            // 
            // picOpponent2
            // 
            picOpponent2.BackColor = Color.Black;
            picOpponent2.BackgroundImageLayout = ImageLayout.Center;
            picOpponent2.Location = new Point(2121, 396);
            picOpponent2.Margin = new Padding(6, 8, 6, 8);
            picOpponent2.Name = "picOpponent2";
            picOpponent2.Size = new Size(697, 621);
            picOpponent2.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpponent2.TabIndex = 39;
            picOpponent2.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackColor = Color.Black;
            picPlayer.BackgroundImageLayout = ImageLayout.Center;
            picPlayer.Location = new Point(115, 396);
            picPlayer.Margin = new Padding(6, 8, 6, 8);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(678, 640);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 38;
            picPlayer.TabStop = false;
            // 
            // picOpponent
            // 
            picOpponent.BackColor = Color.Black;
            picOpponent.BackgroundImageLayout = ImageLayout.Center;
            picOpponent.Location = new Point(1114, 396);
            picOpponent.Margin = new Padding(6, 8, 6, 8);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(678, 640);
            picOpponent.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpponent.TabIndex = 37;
            picOpponent.TabStop = false;
            // 
            // lblOpponent2
            // 
            lblOpponent2.AutoSize = true;
            lblOpponent2.BackColor = Color.White;
            lblOpponent2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOpponent2.ForeColor = Color.Black;
            lblOpponent2.Location = new Point(2051, 363);
            lblOpponent2.Margin = new Padding(2, 0, 2, 0);
            lblOpponent2.Name = "lblOpponent2";
            lblOpponent2.Size = new Size(0, 89);
            lblOpponent2.TabIndex = 40;
            // 
            // mainGame
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2988, 1732);
            Controls.Add(lblOpponent2);
            Controls.Add(picOpponent2);
            Controls.Add(picPlayer);
            Controls.Add(picOpponent);
            Controls.Add(name2);
            Controls.Add(playerName);
            Controls.Add(name1);
            Controls.Add(lblPlayer);
            Controls.Add(lblOpponent);
            Controls.Add(btnDoIt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 8, 6, 8);
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
        private System.Windows.Forms.Timer tmrStateMachine;
        private System.Windows.Forms.Timer tmrMultiplayer;
        private Label label3;
        private Label lblWeaponSelectBow;
        private Label lblWeaponSelectNerfRev;
        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private Label lblPlayer;
        private Label lblOpponent;
        private Label name1;
        private Label playerName;
        private Label name2;
        private PictureBox picOpponent2;
        private PictureBox picPlayer;
        private PictureBox picOpponent;
        private Label lblOpponent2;
    }
}