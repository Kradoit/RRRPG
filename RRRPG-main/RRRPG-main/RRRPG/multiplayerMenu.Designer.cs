using RRRPG.Properties;

namespace RRRPG
{
    partial class multiplayerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(multiplayerMenu));
            tmrPlayMusicAfterGameOver = new System.Windows.Forms.Timer(components);
            player1 = new Label();
            btnStart = new Button();
            tmrStateMachine = new System.Windows.Forms.Timer(components);
            lblOpponent = new Label();
            lblPlayer = new Label();
            lblOpponentSpeak = new Label();
            text3 = new Label();
            button2 = new Button();
            nameBox = new TextBox();
            label1 = new Label();
            serverList = new ListBox();
            label3 = new Label();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // tmrPlayMusicAfterGameOver
            // 
            tmrPlayMusicAfterGameOver.Interval = 2000;
            // 
            // player1
            // 
            player1.Location = new Point(0, 0);
            player1.Margin = new Padding(1, 0, 1, 0);
            player1.Name = "player1";
            player1.Size = new Size(47, 11);
            player1.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(109, 370);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(257, 94);
            btnStart.TabIndex = 17;
            btnStart.Text = "Join";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblOpponent
            // 
            lblOpponent.Location = new Point(0, 0);
            lblOpponent.Margin = new Padding(1, 0, 1, 0);
            lblOpponent.Name = "lblOpponent";
            lblOpponent.Size = new Size(47, 11);
            lblOpponent.TabIndex = 18;
            // 
            // lblPlayer
            // 
            lblPlayer.Location = new Point(0, 0);
            lblPlayer.Margin = new Padding(1, 0, 1, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(47, 11);
            lblPlayer.TabIndex = 19;
            // 
            // lblOpponentSpeak
            // 
            lblOpponentSpeak.Location = new Point(0, 0);
            lblOpponentSpeak.Margin = new Padding(1, 0, 1, 0);
            lblOpponentSpeak.Name = "lblOpponentSpeak";
            lblOpponentSpeak.Size = new Size(47, 11);
            lblOpponentSpeak.TabIndex = 2;
            // 
            // text3
            // 
            text3.Location = new Point(0, 0);
            text3.Margin = new Padding(1, 0, 1, 0);
            text3.Name = "text3";
            text3.Size = new Size(47, 11);
            text3.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(109, 229);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(257, 94);
            button2.TabIndex = 21;
            button2.Text = "Host Game";
            button2.UseVisualStyleBackColor = true;
            button2.Click += hostGame;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(124, 127);
            nameBox.Margin = new Padding(1);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(232, 52);
            nameBox.TabIndex = 22;
            nameBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(192, 70);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 37);
            label1.TabIndex = 23;
            label1.Text = "Name";
            // 
            // serverList
            // 
            serverList.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            serverList.FormattingEnabled = true;
            serverList.ItemHeight = 45;
            serverList.Location = new Point(464, 175);
            serverList.Margin = new Padding(1);
            serverList.Name = "serverList";
            serverList.Size = new Size(273, 184);
            serverList.TabIndex = 24;
            serverList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(489, 111);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(137, 37);
            label3.TabIndex = 26;
            label3.Text = "Server List";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Resources.reload;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(649, 93);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(71, 68);
            button1.TabIndex = 27;
            button1.UseVisualStyleBackColor = true;
            button1.Click += reload;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 14);
            button3.Name = "button3";
            button3.Size = new Size(125, 64);
            button3.TabIndex = 28;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // multiplayerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(905, 515);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(serverList);
            Controls.Add(label1);
            Controls.Add(nameBox);
            Controls.Add(button2);
            Controls.Add(text3);
            Controls.Add(player1);
            Controls.Add(lblOpponentSpeak);
            Controls.Add(btnStart);
            Controls.Add(lblOpponent);
            Controls.Add(lblPlayer);
            Margin = new Padding(2);
            Name = "multiplayerMenu";
            Text = "Form1";
            FormClosed += FrmMain2_FormClosed;
            Load += FrmMain2_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Timer tmrPlayMusicAfterGameOver;
        private Label player1;
        private Button btnStart;
        private System.Windows.Forms.Timer tmrStateMachine;
        private Label lblOpponent;
        private Label lblPlayer;
        private PictureBox picOpponent2;
        private Label lblOpponentSpeak;
        private Label text3;
        private Button button2;
        private TextBox nameBox;
        private Label label1;
        private ListBox serverList;
        private Label label3;
        private Button button1;
        private Button button3;
    }
}