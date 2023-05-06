using RRRPG.Properties;

namespace RRRPG
{
    partial class FrmMain2
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
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            lblPlayerSpeak = new Label();
            btnStart = new Button();
            tmrStateMachine = new System.Windows.Forms.Timer(components);
            lblWeaponSelectBow = new Label();
            picWeaponSelectBow = new PictureBox();
            lblWeaponSelectNerfRev = new Label();
            picWeaponSelectMagicWand = new PictureBox();
            lblWeaponSelectMagicWand = new Label();
            lblOpponent = new Label();
            picWeaponSelectNerfRev = new PictureBox();
            label3 = new Label();
            lblWeaponSelectWaterGun = new Label();
            lblWeaponSelectCorkGun = new Label();
            picWeaponSelectWaterGun = new PictureBox();
            picWeaponSelectCorkGun = new PictureBox();
            panWeaponSelect = new Panel();
            lblPlayer = new Label();
            btnDoIt = new Button();
            picPlayer = new PictureBox();
            picOpponent = new PictureBox();
            picOpponent2 = new PictureBox();
            lblOpponentSpeak = new Label();
            lblOpponentSpeak2 = new Label();
            panWeaponSelect2 = new Panel();
            lblWeaponSelectBow2 = new Label();
            picWeaponSelectBow2 = new PictureBox();
            lblWeaponSelectNerfRev2 = new Label();
            picWeaponSelectNerfRev2 = new PictureBox();
            label5 = new Label();
            lblWeaponSelectWaterGun2 = new Label();
            lblWeaponSelectCorkGun2 = new Label();
            picWeaponSelectWaterGun2 = new PictureBox();
            picWeaponSelectCorkGun2 = new PictureBox();
            picWeaponSelectMagicWand2 = new PictureBox();
            lblWeaponSelectMagicWand2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).BeginInit();
            panWeaponSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).BeginInit();
            panWeaponSelect2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand2).BeginInit();
            SuspendLayout();
            // 
            // tmrPlayMusicAfterGameOver
            // 
            tmrPlayMusicAfterGameOver.Interval = 2000;
            // 
            // lblPlayerSpeak
            // 
            lblPlayerSpeak.AutoSize = true;
            lblPlayerSpeak.BackColor = Color.White;
            lblPlayerSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayerSpeak.Location = new Point(411, 75);
            lblPlayerSpeak.Margin = new Padding(4, 0, 4, 0);
            lblPlayerSpeak.Name = "lblPlayerSpeak";
            lblPlayerSpeak.Size = new Size(425, 48);
            lblPlayerSpeak.TabIndex = 19;
            lblPlayerSpeak.Text = "Bite my shiny metal ass!";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(136, 957);
            btnStart.Margin = new Padding(4, 5, 4, 5);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(321, 117);
            btnStart.TabIndex = 17;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // tmrStateMachine
            // 
            tmrStateMachine.Interval = 40;
            // 
            // lblWeaponSelectBow
            // 
            lblWeaponSelectBow.AutoSize = true;
            lblWeaponSelectBow.BackColor = Color.Black;
            lblWeaponSelectBow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectBow.ForeColor = Color.White;
            lblWeaponSelectBow.Location = new Point(714, 277);
            lblWeaponSelectBow.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectBow.Name = "lblWeaponSelectBow";
            lblWeaponSelectBow.Size = new Size(63, 32);
            lblWeaponSelectBow.TabIndex = 15;
            lblWeaponSelectBow.Text = "Bow";
            // 
            // picWeaponSelectBow
            // 
            picWeaponSelectBow.BackColor = Color.Black;
            picWeaponSelectBow.BackgroundImage = Resources.Img_Bow;
            picWeaponSelectBow.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectBow.Location = new Point(666, 18);
            picWeaponSelectBow.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectBow.Name = "picWeaponSelectBow";
            picWeaponSelectBow.Size = new Size(143, 253);
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
            lblWeaponSelectNerfRev.Location = new Point(501, 277);
            lblWeaponSelectNerfRev.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectNerfRev.Name = "lblWeaponSelectNerfRev";
            lblWeaponSelectNerfRev.Size = new Size(172, 32);
            lblWeaponSelectNerfRev.TabIndex = 13;
            lblWeaponSelectNerfRev.Text = "Nerf Revolver";
            // 
            // picWeaponSelectMagicWand
            // 
            picWeaponSelectMagicWand.BackColor = Color.Black;
            picWeaponSelectMagicWand.BackgroundImage = Resources.Img_Magic_Wand;
            picWeaponSelectMagicWand.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectMagicWand.Location = new Point(18, 15);
            picWeaponSelectMagicWand.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectMagicWand.Name = "picWeaponSelectMagicWand";
            picWeaponSelectMagicWand.Size = new Size(183, 255);
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
            lblWeaponSelectMagicWand.Location = new Point(66, 277);
            lblWeaponSelectMagicWand.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectMagicWand.Name = "lblWeaponSelectMagicWand";
            lblWeaponSelectMagicWand.Size = new Size(84, 32);
            lblWeaponSelectMagicWand.TabIndex = 6;
            lblWeaponSelectMagicWand.Text = "Magic";
            // 
            // lblOpponent
            // 
            lblOpponent.AutoSize = true;
            lblOpponent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponent.ForeColor = Color.White;
            lblOpponent.Location = new Point(1149, -127);
            lblOpponent.Margin = new Padding(4, 0, 4, 0);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(190, 48);
            lblOpponent.TabIndex = 15;
            lblOpponent.Text = "Opponent";
            // 
            // picWeaponSelectNerfRev
            // 
            picWeaponSelectNerfRev.BackColor = Color.Black;
            picWeaponSelectNerfRev.BackgroundImage = Resources.Img_Nerf_Revolver;
            picWeaponSelectNerfRev.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectNerfRev.Location = new Point(511, 18);
            picWeaponSelectNerfRev.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectNerfRev.Name = "picWeaponSelectNerfRev";
            picWeaponSelectNerfRev.Size = new Size(143, 253);
            picWeaponSelectNerfRev.TabIndex = 12;
            picWeaponSelectNerfRev.TabStop = false;
            picWeaponSelectNerfRev.Click += picWeaponSelectNerfRev_Click;
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
            // lblWeaponSelectWaterGun
            // 
            lblWeaponSelectWaterGun.AutoSize = true;
            lblWeaponSelectWaterGun.BackColor = Color.Black;
            lblWeaponSelectWaterGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectWaterGun.ForeColor = Color.White;
            lblWeaponSelectWaterGun.Location = new Point(369, 275);
            lblWeaponSelectWaterGun.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectWaterGun.Name = "lblWeaponSelectWaterGun";
            lblWeaponSelectWaterGun.Size = new Size(136, 32);
            lblWeaponSelectWaterGun.TabIndex = 10;
            lblWeaponSelectWaterGun.Text = "Water Gun";
            // 
            // lblWeaponSelectCorkGun
            // 
            lblWeaponSelectCorkGun.AutoSize = true;
            lblWeaponSelectCorkGun.BackColor = Color.Black;
            lblWeaponSelectCorkGun.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectCorkGun.ForeColor = Color.White;
            lblWeaponSelectCorkGun.Location = new Point(223, 275);
            lblWeaponSelectCorkGun.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectCorkGun.Name = "lblWeaponSelectCorkGun";
            lblWeaponSelectCorkGun.Size = new Size(121, 32);
            lblWeaponSelectCorkGun.TabIndex = 9;
            lblWeaponSelectCorkGun.Text = "Cork Gun";
            // 
            // picWeaponSelectWaterGun
            // 
            picWeaponSelectWaterGun.BackColor = Color.Black;
            picWeaponSelectWaterGun.BackgroundImage = Resources.Img_Water_Gun;
            picWeaponSelectWaterGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectWaterGun.Location = new Point(360, 17);
            picWeaponSelectWaterGun.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectWaterGun.Name = "picWeaponSelectWaterGun";
            picWeaponSelectWaterGun.Size = new Size(143, 253);
            picWeaponSelectWaterGun.TabIndex = 8;
            picWeaponSelectWaterGun.TabStop = false;
            picWeaponSelectWaterGun.Click += picWeaponSelectWaterGun_Click;
            // 
            // picWeaponSelectCorkGun
            // 
            picWeaponSelectCorkGun.BackColor = Color.Black;
            picWeaponSelectCorkGun.BackgroundImage = Resources.Img_Cork_Gun;
            picWeaponSelectCorkGun.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectCorkGun.Location = new Point(209, 17);
            picWeaponSelectCorkGun.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectCorkGun.Name = "picWeaponSelectCorkGun";
            picWeaponSelectCorkGun.Size = new Size(143, 253);
            picWeaponSelectCorkGun.TabIndex = 7;
            picWeaponSelectCorkGun.TabStop = false;
            picWeaponSelectCorkGun.Click += picWeaponSelectCorkGun_Click;
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
            panWeaponSelect.Controls.Add(lblWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectWaterGun);
            panWeaponSelect.Controls.Add(picWeaponSelectCorkGun);
            panWeaponSelect.Controls.Add(picWeaponSelectMagicWand);
            panWeaponSelect.Controls.Add(lblWeaponSelectMagicWand);
            panWeaponSelect.Location = new Point(530, 882);
            panWeaponSelect.Margin = new Padding(4, 5, 4, 5);
            panWeaponSelect.Name = "panWeaponSelect";
            panWeaponSelect.Size = new Size(809, 382);
            panWeaponSelect.TabIndex = 16;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(365, -130);
            lblPlayer.Margin = new Padding(4, 0, 4, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(123, 48);
            lblPlayer.TabIndex = 14;
            lblPlayer.Text = "Player";
            // 
            // btnDoIt
            // 
            btnDoIt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDoIt.Location = new Point(79, 828);
            btnDoIt.Margin = new Padding(4, 5, 4, 5);
            btnDoIt.Name = "btnDoIt";
            btnDoIt.Size = new Size(321, 117);
            btnDoIt.TabIndex = 13;
            btnDoIt.Text = "Try Your Luck!";
            btnDoIt.UseVisualStyleBackColor = true;
            btnDoIt.Click += btnDoIt_Click;
            // 
            // picPlayer
            // 
            picPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            picPlayer.Image = Resources.Img_Bender_Idle;
            picPlayer.Location = new Point(26, 147);
            picPlayer.Margin = new Padding(4, 5, 4, 5);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(660, 571);
            picPlayer.TabIndex = 12;
            picPlayer.TabStop = false;
            // 
            // picOpponent
            // 
            picOpponent.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent.Location = new Point(820, 147);
            picOpponent.Margin = new Padding(4, 5, 4, 5);
            picOpponent.Name = "picOpponent";
            picOpponent.Size = new Size(630, 705);
            picOpponent.TabIndex = 11;
            picOpponent.TabStop = false;
            // 
            // picOpponent2
            // 
            picOpponent2.BackgroundImageLayout = ImageLayout.Stretch;
            picOpponent2.Location = new Point(1644, 207);
            picOpponent2.Margin = new Padding(4, 5, 4, 5);
            picOpponent2.Name = "picOpponent2";
            picOpponent2.Size = new Size(584, 645);
            picOpponent2.TabIndex = 20;
            picOpponent2.TabStop = false;
            // 
            // lblOpponentSpeak
            // 
            lblOpponentSpeak.AutoSize = true;
            lblOpponentSpeak.BackColor = Color.White;
            lblOpponentSpeak.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponentSpeak.Location = new Point(1090, 75);
            lblOpponentSpeak.Margin = new Padding(4, 0, 4, 0);
            lblOpponentSpeak.Name = "lblOpponentSpeak";
            lblOpponentSpeak.Size = new Size(312, 48);
            lblOpponentSpeak.TabIndex = 18;
            lblOpponentSpeak.Text = "I will outlast you!";
            // 
            // lblOpponentSpeak2
            // 
            lblOpponentSpeak2.AutoSize = true;
            lblOpponentSpeak2.BackColor = Color.White;
            lblOpponentSpeak2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpponentSpeak2.Location = new Point(1961, 120);
            lblOpponentSpeak2.Margin = new Padding(4, 0, 4, 0);
            lblOpponentSpeak2.Name = "lblOpponentSpeak2";
            lblOpponentSpeak2.Size = new Size(160, 48);
            lblOpponentSpeak2.TabIndex = 21;
            lblOpponentSpeak2.Text = "so will I!";
            // 
            // panWeaponSelect2
            // 
            panWeaponSelect2.BackColor = Color.Black;
            panWeaponSelect2.Controls.Add(lblWeaponSelectBow2);
            panWeaponSelect2.Controls.Add(picWeaponSelectBow2);
            panWeaponSelect2.Controls.Add(lblWeaponSelectNerfRev2);
            panWeaponSelect2.Controls.Add(picWeaponSelectNerfRev2);
            panWeaponSelect2.Controls.Add(label5);
            panWeaponSelect2.Controls.Add(lblWeaponSelectWaterGun2);
            panWeaponSelect2.Controls.Add(lblWeaponSelectCorkGun2);
            panWeaponSelect2.Controls.Add(picWeaponSelectWaterGun2);
            panWeaponSelect2.Controls.Add(picWeaponSelectCorkGun2);
            panWeaponSelect2.Controls.Add(picWeaponSelectMagicWand2);
            panWeaponSelect2.Controls.Add(lblWeaponSelectMagicWand2);
            panWeaponSelect2.Location = new Point(1467, 897);
            panWeaponSelect2.Margin = new Padding(4, 5, 4, 5);
            panWeaponSelect2.Name = "panWeaponSelect2";
            panWeaponSelect2.Size = new Size(809, 382);
            panWeaponSelect2.TabIndex = 22;
            // 
            // lblWeaponSelectBow2
            // 
            lblWeaponSelectBow2.AutoSize = true;
            lblWeaponSelectBow2.BackColor = Color.Black;
            lblWeaponSelectBow2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectBow2.ForeColor = Color.White;
            lblWeaponSelectBow2.Location = new Point(714, 277);
            lblWeaponSelectBow2.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectBow2.Name = "lblWeaponSelectBow2";
            lblWeaponSelectBow2.Size = new Size(63, 32);
            lblWeaponSelectBow2.TabIndex = 15;
            lblWeaponSelectBow2.Text = "Bow";
            // 
            // picWeaponSelectBow2
            // 
            picWeaponSelectBow2.BackColor = Color.Black;
            picWeaponSelectBow2.BackgroundImage = Resources.Img_Bow;
            picWeaponSelectBow2.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectBow2.Location = new Point(666, 18);
            picWeaponSelectBow2.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectBow2.Name = "picWeaponSelectBow2";
            picWeaponSelectBow2.Size = new Size(143, 253);
            picWeaponSelectBow2.TabIndex = 14;
            picWeaponSelectBow2.TabStop = false;
            picWeaponSelectBow2.Click += picWeaponSelectBow2_Click;
            // 
            // lblWeaponSelectNerfRev2
            // 
            lblWeaponSelectNerfRev2.AutoSize = true;
            lblWeaponSelectNerfRev2.BackColor = Color.Black;
            lblWeaponSelectNerfRev2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectNerfRev2.ForeColor = Color.White;
            lblWeaponSelectNerfRev2.Location = new Point(501, 277);
            lblWeaponSelectNerfRev2.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectNerfRev2.Name = "lblWeaponSelectNerfRev2";
            lblWeaponSelectNerfRev2.Size = new Size(172, 32);
            lblWeaponSelectNerfRev2.TabIndex = 13;
            lblWeaponSelectNerfRev2.Text = "Nerf Revolver";
            // 
            // picWeaponSelectNerfRev2
            // 
            picWeaponSelectNerfRev2.BackColor = Color.Black;
            picWeaponSelectNerfRev2.BackgroundImage = Resources.Img_Nerf_Revolver;
            picWeaponSelectNerfRev2.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectNerfRev2.Location = new Point(511, 18);
            picWeaponSelectNerfRev2.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectNerfRev2.Name = "picWeaponSelectNerfRev2";
            picWeaponSelectNerfRev2.Size = new Size(143, 253);
            picWeaponSelectNerfRev2.TabIndex = 12;
            picWeaponSelectNerfRev2.TabStop = false;
            picWeaponSelectNerfRev2.Click += picWeaponSelectNerfRev2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(294, 325);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(241, 45);
            label5.TabIndex = 11;
            label5.Text = "Weapon Select";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWeaponSelectWaterGun2
            // 
            lblWeaponSelectWaterGun2.AutoSize = true;
            lblWeaponSelectWaterGun2.BackColor = Color.Black;
            lblWeaponSelectWaterGun2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectWaterGun2.ForeColor = Color.White;
            lblWeaponSelectWaterGun2.Location = new Point(369, 275);
            lblWeaponSelectWaterGun2.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectWaterGun2.Name = "lblWeaponSelectWaterGun2";
            lblWeaponSelectWaterGun2.Size = new Size(136, 32);
            lblWeaponSelectWaterGun2.TabIndex = 10;
            lblWeaponSelectWaterGun2.Text = "Water Gun";
            // 
            // lblWeaponSelectCorkGun2
            // 
            lblWeaponSelectCorkGun2.AutoSize = true;
            lblWeaponSelectCorkGun2.BackColor = Color.Black;
            lblWeaponSelectCorkGun2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectCorkGun2.ForeColor = Color.White;
            lblWeaponSelectCorkGun2.Location = new Point(223, 275);
            lblWeaponSelectCorkGun2.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectCorkGun2.Name = "lblWeaponSelectCorkGun2";
            lblWeaponSelectCorkGun2.Size = new Size(121, 32);
            lblWeaponSelectCorkGun2.TabIndex = 9;
            lblWeaponSelectCorkGun2.Text = "Cork Gun";
            // 
            // picWeaponSelectWaterGun2
            // 
            picWeaponSelectWaterGun2.BackColor = Color.Black;
            picWeaponSelectWaterGun2.BackgroundImage = Resources.Img_Water_Gun;
            picWeaponSelectWaterGun2.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectWaterGun2.Location = new Point(360, 17);
            picWeaponSelectWaterGun2.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectWaterGun2.Name = "picWeaponSelectWaterGun2";
            picWeaponSelectWaterGun2.Size = new Size(143, 253);
            picWeaponSelectWaterGun2.TabIndex = 8;
            picWeaponSelectWaterGun2.TabStop = false;
            picWeaponSelectWaterGun2.Click += picWeaponSelectWaterGun2_Click;
            // 
            // picWeaponSelectCorkGun2
            // 
            picWeaponSelectCorkGun2.BackColor = Color.Black;
            picWeaponSelectCorkGun2.BackgroundImage = Resources.Img_Cork_Gun;
            picWeaponSelectCorkGun2.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectCorkGun2.Location = new Point(209, 17);
            picWeaponSelectCorkGun2.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectCorkGun2.Name = "picWeaponSelectCorkGun2";
            picWeaponSelectCorkGun2.Size = new Size(143, 253);
            picWeaponSelectCorkGun2.TabIndex = 7;
            picWeaponSelectCorkGun2.TabStop = false;
            picWeaponSelectCorkGun2.Click += picWeaponSelectCorkGun2_Click;
            // 
            // picWeaponSelectMagicWand2
            // 
            picWeaponSelectMagicWand2.BackColor = Color.Black;
            picWeaponSelectMagicWand2.BackgroundImage = Resources.Img_Magic_Wand;
            picWeaponSelectMagicWand2.BackgroundImageLayout = ImageLayout.Zoom;
            picWeaponSelectMagicWand2.Location = new Point(18, 15);
            picWeaponSelectMagicWand2.Margin = new Padding(4, 5, 4, 5);
            picWeaponSelectMagicWand2.Name = "picWeaponSelectMagicWand2";
            picWeaponSelectMagicWand2.Size = new Size(183, 255);
            picWeaponSelectMagicWand2.TabIndex = 5;
            picWeaponSelectMagicWand2.TabStop = false;
            picWeaponSelectMagicWand2.Click += picWeaponSelectMagicWand2_Click;
            // 
            // lblWeaponSelectMagicWand2
            // 
            lblWeaponSelectMagicWand2.AutoSize = true;
            lblWeaponSelectMagicWand2.BackColor = Color.Black;
            lblWeaponSelectMagicWand2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWeaponSelectMagicWand2.ForeColor = Color.White;
            lblWeaponSelectMagicWand2.Location = new Point(66, 277);
            lblWeaponSelectMagicWand2.Margin = new Padding(4, 0, 4, 0);
            lblWeaponSelectMagicWand2.Name = "lblWeaponSelectMagicWand2";
            lblWeaponSelectMagicWand2.Size = new Size(84, 32);
            lblWeaponSelectMagicWand2.TabIndex = 6;
            lblWeaponSelectMagicWand2.Text = "Magic";
            // 
            // FrmMain2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(2260, 1312);
            Controls.Add(panWeaponSelect2);
            Controls.Add(lblOpponentSpeak2);
            Controls.Add(picOpponent2);
            Controls.Add(lblPlayerSpeak);
            Controls.Add(lblOpponentSpeak);
            Controls.Add(btnStart);
            Controls.Add(lblOpponent);
            Controls.Add(panWeaponSelect);
            Controls.Add(lblPlayer);
            Controls.Add(btnDoIt);
            Controls.Add(picPlayer);
            Controls.Add(picOpponent);
            Name = "FrmMain2";
            Text = "Form1";
            FormClosed += FrmMain2_FormClosed;
            Load += FrmMain2_Load;
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun).EndInit();
            panWeaponSelect.ResumeLayout(false);
            panWeaponSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOpponent2).EndInit();
            panWeaponSelect2.ResumeLayout(false);
            panWeaponSelect2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectBow2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectNerfRev2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectWaterGun2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectCorkGun2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWeaponSelectMagicWand2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private Label lblPlayerSpeak;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrStateMachine;
        private Label lblWeaponSelectBow;
        private PictureBox picWeaponSelectBow;
        private Label lblWeaponSelectNerfRev;
        private PictureBox picWeaponSelectMagicWand;
        private Label lblWeaponSelectMagicWand;
        private Label lblOpponent;
        private PictureBox picWeaponSelectNerfRev;
        private Label label3;
        private Label lblWeaponSelectWaterGun;
        private Label lblWeaponSelectCorkGun;
        private PictureBox picWeaponSelectWaterGun;
        private PictureBox picWeaponSelectCorkGun;
        private Panel panWeaponSelect;
        private Label lblPlayer;
        private Button btnDoIt;
        private PictureBox picPlayer;
        private PictureBox picOpponent;
        private PictureBox picOpponent2;
        private Label lblOpponentSpeak;
        private Label lblOpponentSpeak2;
        private Panel panWeaponSelect2;
        private Label lblWeaponSelectBow2;
        private PictureBox picWeaponSelectBow2;
        private Label lblWeaponSelectNerfRev2;
        private PictureBox picWeaponSelectNerfRev2;
        private Label label5;
        private Label lblWeaponSelectWaterGun2;
        private Label lblWeaponSelectCorkGun2;
        private PictureBox picWeaponSelectWaterGun2;
        private PictureBox picWeaponSelectCorkGun2;
        private PictureBox picWeaponSelectMagicWand2;
        private Label lblWeaponSelectMagicWand2;
    }
}