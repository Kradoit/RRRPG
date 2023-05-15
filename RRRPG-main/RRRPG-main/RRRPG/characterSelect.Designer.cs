using RRRPG.Properties;

namespace RRRPG
{
    partial class CharacterSelect
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelect));
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            player1 = new Label();
            btnStart = new Button();
            hostStateMachine = new System.Windows.Forms.Timer(components);
            userStateMachine = new System.Windows.Forms.Timer(components);
            lblWeaponSelectBow = new Label();
            picWeaponSelectBow = new PictureBox();
            lblWeaponSelectNerfRev = new Label();
            picWeaponSelectMagicWand = new PictureBox();
            lblWeaponSelectMagicWand = new Label();
            lblOpponent = new Label();
            picWeaponSelectNerfRev = new PictureBox();
            label3 = new Label();
            lblWeaponSelectWaterGun = new Label();
            picWeaponSelectWaterGun = new PictureBox();
            panWeaponSelect = new Panel();
            lblPlayer = new Label();
            picOpponent = new PictureBox();
            picOpponent2 = new PictureBox();
            picPlayer = new PictureBox();
            lblOpponentSpeak = new Label();
            text3 = new Label();
            multiStart = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).BeginInit();
            panWeaponSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            SuspendLayout();
            // 
            // tmrPlayMusicAfterGameOver
            // 
            tmrPlayMusicAfterGameOver.Interval = 2000;
            // 
            // player1
            // 
            player1.AutoSize = true;
            player1.BackColor = Color.White;
            player1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            player1.Location = new Point(151, 95);
            player1.Name = "player1";
            player1.Size = new Size(186, 41);
            player1.TabIndex = 19;
            player1.Text = "Opponent 1";
            player1.Click += lblPlayerSpeak_Click;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(118, 762);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(257, 94);
            btnStart.TabIndex = 17;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // hostStateMachine
            // 
            hostStateMachine.Interval = 2;
            hostStateMachine.Tick += host;
            // 
            // userStateMachine
            // 
            userStateMachine.Interval = 2;
            userStateMachine.Tick += checkForData;
            // 
            // lblWeaponSelectBow
            // 
            lblWeaponSelectBow.AutoSize = true;
            lblWeaponSelectBow.BackColor = Color.Black;
            lblWeaponSelectBow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectBow.ForeColor = Color.White;
            lblWeaponSelectBow.Location = new Point(555, 221);
            lblWeaponSelectBow.Name = "lblWeaponSelectBow";
            lblWeaponSelectBow.Size = new Size(53, 28);
            lblWeaponSelectBow.TabIndex = 15;
            lblWeaponSelectBow.Text = "Bow";
            // 
            // picWeaponSelectBow
            // 
            picWeaponSelectBow.BackColor = Color.Black;
            picWeaponSelectBow.BackgroundImage = Resources.Img_Bow;
            picWeaponSelectBow.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectBow.Location = new Point(525, 15);
            picWeaponSelectBow.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectBow.Name = "picWeaponSelectBow";
            picWeaponSelectBow.Size = new Size(114, 202);
            picWeaponSelectBow.TabIndex = 14;
            picWeaponSelectBow.TabStop = false;
            picWeaponSelectBow.Click += picWeaponSelectBow_Click;
            // 
            // lblWeaponSelectNerfRev
            // 
            lblWeaponSelectNerfRev.AutoSize = true;
            lblWeaponSelectNerfRev.BackColor = Color.Black;
            lblWeaponSelectNerfRev.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectNerfRev.ForeColor = Color.White;
            lblWeaponSelectNerfRev.Location = new Point(366, 220);
            lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
            lblWeaponSelectNerfRev.Size = new Size(144, 28);
            lblWeaponSelectNerfRev.TabIndex = 13;
            lblWeaponSelectNerfRev.Text = "Nerf Revolver";
            // 
            // picWeaponSelectMagicWand
            // 
            picWeaponSelectMagicWand.BackColor = Color.Black;
            picWeaponSelectMagicWand.BackgroundImage = Resources.Img_Magic_Wand;
            picWeaponSelectMagicWand.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectMagicWand.Location = new Point(53, 12);
            picWeaponSelectMagicWand.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
            picWeaponSelectMagicWand.Size = new Size(146, 204);
            picWeaponSelectMagicWand.TabIndex = 5;
            picWeaponSelectMagicWand.TabStop = false;
            picWeaponSelectMagicWand.Click += picWeaponSelectMagicWand_Click;
            // 
            // lblWeaponSelectMagicWand
            // 
            lblWeaponSelectMagicWand.AutoSize = true;
            lblWeaponSelectMagicWand.BackColor = Color.Black;
            lblWeaponSelectMagicWand.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectMagicWand.ForeColor = Color.White;
            lblWeaponSelectMagicWand.Location = new Point(94, 221);
            lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
            lblWeaponSelectMagicWand.Size = new Size(70, 28);
            lblWeaponSelectMagicWand.TabIndex = 6;
            lblWeaponSelectMagicWand.Text = "Magic";
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.ForeColor = Color.White;
            lblOpponent.Location = new Point(919, -101);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(161, 41);
            lblOpponent.TabIndex = 15;
            lblOpponent.Text = "Opponent";
            // 
            // picWeaponSelectNerfRev
            // 
            picWeaponSelectNerfRev.BackColor = Color.Black;
            picWeaponSelectNerfRev.BackgroundImage = Resources.Img_Nerf_Revolver;
            picWeaponSelectNerfRev.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectNerfRev.Location = new Point(377, 15);
            picWeaponSelectNerfRev.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
            picWeaponSelectNerfRev.Size = new Size(114, 202);
            picWeaponSelectNerfRev.TabIndex = 12;
            picWeaponSelectNerfRev.TabStop = false;
            picWeaponSelectNerfRev.Click += picWeaponSelectNerfRev_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(235, 260);
            label3.Name = "label3";
            label3.Size = new Size(207, 37);
            label3.TabIndex = 11;
            label3.Text = "Weapon Select";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeaponSelectWaterGun
            // 
            lblWeaponSelectWaterGun.AutoSize = true;
            lblWeaponSelectWaterGun.BackColor = Color.Black;
            lblWeaponSelectWaterGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectWaterGun.ForeColor = Color.White;
            lblWeaponSelectWaterGun.Location = new Point(236, 220);
            lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
            lblWeaponSelectWaterGun.Size = new Size(113, 28);
            lblWeaponSelectWaterGun.TabIndex = 10;
            lblWeaponSelectWaterGun.Text = "Water Gun";
            // 
            // picWeaponSelectWaterGun
            // 
            picWeaponSelectWaterGun.BackColor = Color.Black;
            picWeaponSelectWaterGun.BackgroundImage = Resources.Img_Water_Gun;
            picWeaponSelectWaterGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectWaterGun.Location = new Point(235, 14);
            picWeaponSelectWaterGun.Margin = new Padding(3, 4, 3, 4);
            picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
            picWeaponSelectWaterGun.Size = new Size(114, 202);
            picWeaponSelectWaterGun.TabIndex = 8;
            picWeaponSelectWaterGun.TabStop = false;
            picWeaponSelectWaterGun.Click += picWeaponSelectWaterGun_Click;
            // 
            // panWeaponSelect
            // 
            panWeaponSelect.BackColor = Color.Black;
            panWeaponSelect.Controls.Add(lblWeaponSelectBow);
            panWeaponSelect.Controls.Add(picWeaponSelectBow);
            panWeaponSelect.Controls.Add(lblWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(picWeaponSelectNerfRev);
            panWeaponSelect.Controls.Add(label3);
            panWeaponSelect.Controls.Add(lblWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(picWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(picWeaponSelectMagicWand);
            panWeaponSelect.Controls.Add(lblWeaponSelectMagicWand);
            panWeaponSelect.Location = new Point(433, 597);
            panWeaponSelect.Margin = new Padding(3, 4, 3, 4);
            panWeaponSelect.Name = "panWeaponSelect";
            panWeaponSelect.Size = new Size(664, 305);
            panWeaponSelect.TabIndex = 16;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(292, -104);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(105, 41);
            lblPlayer.TabIndex = 14;
            lblPlayer.Text = "Player";
            // 
            // picOpponent
            // 
            picOpponent.BackgroundImageLayout = ImageLayout.Center;
            picOpponent.Image = Resources.Img_Shadow_Idle;
            picOpponent.Location = new Point(74, 162);
            picOpponent.Margin = new Padding(3, 4, 3, 4);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(319, 312);
            picOpponent.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpponent.TabIndex = 12;
            picOpponent.TabStop = false;
            // 
            // picOpponent2
            // 
            picOpponent2.BackgroundImageLayout = ImageLayout.Center;
            picOpponent2.Image = Resources.Img_Shadow_Idle;
            picOpponent2.Location = new Point(1099, 162);
            picOpponent2.Margin = new Padding(3, 4, 3, 4);
            picOpponent2.Name = "picOpponent2";
            picOpponent2.Size = new Size(319, 312);
            picOpponent2.SizeMode = PictureBoxSizeMode.StretchImage;
            picOpponent2.TabIndex = 20;
            picOpponent2.TabStop = false;
            // 
            // picPlayer
            // 
            picPlayer.BackgroundImageLayout = ImageLayout.Center;
            picPlayer.Image = Resources.Img_Shadow_Idle;
            picPlayer.Location = new Point(553, 136);
            picPlayer.Margin = new Padding(3, 4, 3, 4);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(381, 391);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 11;
            picPlayer.TabStop = false;
            // 
            // lblOpponentSpeak
            // 
            lblOpponentSpeak.AutoSize = true;
            lblOpponentSpeak.BackColor = Color.White;
            lblOpponentSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponentSpeak.Location = new Point(705, 51);
            lblOpponentSpeak.Margin = new Padding(2, 0, 2, 0);
            lblOpponentSpeak.Name = "lblOpponentSpeak";
            lblOpponentSpeak.Size = new Size(69, 41);
            lblOpponentSpeak.TabIndex = 18;
            lblOpponentSpeak.Text = "You";
            // 
            // text3
            // 
            text3.AutoSize = true;
            text3.BackColor = Color.White;
            text3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            text3.Location = new Point(1183, 95);
            text3.Margin = new Padding(2, 0, 2, 0);
            text3.Name = "text3";
            text3.Size = new Size(181, 41);
            text3.TabIndex = 21;
            text3.Text = "opponent 2";
            // 
            // multiStart
            // 
            multiStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            multiStart.Location = new Point(118, 612);
            multiStart.Margin = new Padding(6);
            multiStart.Name = "multiStart";
            multiStart.Size = new Size(257, 94);
            multiStart.TabIndex = 22;
            multiStart.Text = "START";
            multiStart.UseVisualStyleBackColor = true;
            multiStart.Visible = false;
            multiStart.Click += multiStart_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(169, 67);
            button1.TabIndex = 16;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CharacterSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1784, 983);
            Controls.Add(button1);
            Controls.Add(multiStart);
            Controls.Add(text3);
            Controls.Add(picOpponent2);
            Controls.Add(player1);
            Controls.Add(lblOpponentSpeak);
            Controls.Add(btnStart);
            Controls.Add(lblOpponent);
            Controls.Add(panWeaponSelect);
            Controls.Add(lblPlayer);
            Controls.Add(picOpponent);
            Controls.Add(picPlayer);
            Margin = new Padding(2);
            Name = "CharacterSelect";
            Text = "Form1";
            FormClosed += FrmMain2_FormClosed;
            Load += FrmMain2_Load;
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).EndInit();
            panWeaponSelect.ResumeLayout(false);
            panWeaponSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private Label player1;
        private Button btnStart;
        private System.Windows.Forms.Timer hostStateMachine;
        private System.Windows.Forms.Timer userStateMachine;
        private Label lblWeaponSelectBow;
        private PictureBox picWeaponSelectBow;
        private Label lblWeaponSelectNerfRev;
        private PictureBox picWeaponSelectMagicWand;
        private Label lblWeaponSelectMagicWand;
        private Label lblOpponent;
        private PictureBox picWeaponSelectNerfRev;
        private Label label3;
        private Label lblWeaponSelectWaterGun;
        private PictureBox picWeaponSelectWaterGun;
        private Panel panWeaponSelect;
        private Label lblPlayer;
        private PictureBox picOpponent;
        private PictureBox picPlayer;
        private PictureBox picOpponent2;
        private Label lblOpponentSpeak;
        private Label text3;
        private Button multiStart;
        private Button button1;
    }
}