using RRRPG.Properties;
using RRRPGLib;
using System.Media;

namespace RRRPG
{
    public partial class mainGame : Form
    {
        private SoundPlayer soundPlayer;
        private int state;
        private Character player;
        private Character opponent;
        private Character opponent2;
        private Weapon weapon;
        private bool opp1Alive = true;
        private bool opp2Alive = true;
        private bool playerAlive = true;
        private Dictionary<WeaponType, (PictureBox pic, Label lbl)> weaponSelectMap;

        private bool threePlayer = false;
        private bool multiPlayer = false;
        private MultiPlayer Network;
        // function to enable multiplayer
        public void setMultiplayer(MultiPlayer Network)
        {
            this.Network = Network;
            this.multiPlayer = true;
        }
        private void start()
        {

            soundPlayer.Stop();
            opp1Alive = true;
            if (this.threePlayer)
                opp2Alive = true;
            else
                opp2Alive = false;
            playerAlive = true;
            player.Shutup();
            player.ShowIdle();
            opponent.ShowIdle();
            btnStart.Visible = false;
            opponent.SaySmack();
            if (this.threePlayer)
                opponent2.SaySmack();
            tmrStateMachine.Interval = 3500;
            tmrStateMachine.Enabled = true;
            state = 0;
        }
        public mainGame(Character player, Character opponent)
        {
            InitializeComponent();
            FormManager.openForms.Add(this);

            this.player = player;
            this.opponent = opponent;
            //this.opponent2 = opponent2;;

        }

        public mainGame(Character player, Character opponent, Character opponent2)
        {
            InitializeComponent();
            FormManager.openForms.Add(this);

            this.player = player;
            this.opponent = opponent;
            this.opponent2 = opponent2;
            threePlayer = true;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music);
            soundPlayer.PlayLooping();
            btnDoIt.Visible = false;
            lblOpponent.Visible = false;
            lblPlayer.Visible = false;
            state = -1;

            this.player.setPic(ref picPlayer);
            this.opponent.setPic(ref picOpponent);

            this.player.setText(ref lblPlayer);
            this.opponent.setText(ref lblOpponent);

            if (this.threePlayer)
            {
                this.opponent2.setPic(ref picOpponent2);
                this.opponent2.setText(ref lblOpponent2);
            }

            start();
        }

        private void tmrDialog_Tick(object sender, EventArgs e)
        {
            if (state == 0)
            {
                opponent.Shutup();
                if(threePlayer)
                    opponent2.Shutup();
                // why not talk on second loop
                player.SaySmack();
                state = 1;
            }
            else if (state == 1)
            {
                if ((opp1Alive == false && opp2Alive == false) || playerAlive == false)
                {
                    state = -1;
                    opponent.ShowIdle();
                    if (threePlayer)
                        opponent2.ShowNoWeapon();
                    picOpponent.Visible = true;
                    if (threePlayer)
                        picOpponent2.Visible = true;
                    lblOpponent.Visible = false;
                    if (threePlayer)
                        lblOpponent2.Visible = false;
                    btnStart.Visible = true;
                    tmrPlayMusicAfterGameOver.Enabled = true;
                    tmrStateMachine.Enabled = false;
                }
                else
                {
                    opponent.Shutup();
                    if (threePlayer)
                        opponent2.Shutup();
                    player.Shutup();
                    player.ShowReady();
                    opponent.ShowNoWeapon();
                    if (threePlayer)
                        opponent2.ShowNoWeapon();
                    btnDoIt.Visible = true;
                    tmrStateMachine.Enabled = false;
                    state = 2;
                }
            }
            else if (state == 3)
            {
                player.SayOw();
                state = 4;
                tmrStateMachine.Interval = 2500;
            }
            else if (state == 4)
            {
                player.SayBoned();
                playerAlive = false;
                state = 1;
            }
            else if (state == 5)
            {
                if (opp1Alive == true)
                {
                    player.Shutup();
                    opponent.ShowReady();
                    state = 6;
                }
                else
                {
                    state = 10;
                }
            }
            else if (state == 6)
            {
                if (opponent.PullTrigger())
                {
                    state = 7;
                }
                else
                {
                    state = 10;
                }
            }
            else if (state == 7)
            {
                opponent.SayOw();
                state = 8;
                tmrStateMachine.Interval = 2500;
            }
            else if (state == 8)
            {
                opponent.SayBoned();
                opp1Alive = false;
                picOpponent.Visible = false;
                state = 10;
            }
            else if (state == 10)
            {
                if (opp2Alive == true)
                {
                    opponent.Shutup();
                    if (threePlayer)
                        opponent2.ShowReady();
                    state = 11;
                }
                else
                {
                    state = 1;
                }
            }
            else if (state == 11)
            {
                if (opponent2.PullTrigger())
                {
                    state = 12;
                }
                else
                {
                    state = 1;
                }
            }
            else if (state == 12)
            {
                opponent2.SayOw();
                state = 13;
                tmrStateMachine.Interval = 2500;
            }
            else if (state == 13)
            {
                opponent2.SayBoned();
                opp2Alive = false;
                picOpponent2.Visible = false;
                state = 1;
            }
            if (!playerAlive && !multiPlayer)
            {
                // end game and put button to return to main menue
            }
            else
            {
                // end game and keep watching
            }
            // check if everyone is dead and end game
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            if (player.PullTrigger())
            {
                state = 3;
                tmrStateMachine.Interval = 2200;
                tmrStateMachine.Enabled = true;
            }
            else
            {
                state = 5;
                tmrStateMachine.Interval = 1500;
                tmrStateMachine.Enabled = true;
            }
            btnDoIt.Visible = false;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.openForms.Remove(this);
            FormManager.CloseAll();
        }

        private void tmrPlayMusicAfterGameOver_Tick(object sender, EventArgs e)
        {
            if (btnStart.Visible)
            {
                soundPlayer.PlayLooping();
            }
            tmrPlayMusicAfterGameOver.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}