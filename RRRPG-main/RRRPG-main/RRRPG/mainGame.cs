using Microsoft.VisualBasic.Devices;
using RRRPG.Properties;
using RRRPGLib;
using System.ComponentModel;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

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
        string lastCommand = "";

        private bool threePlayer = false;
        private bool multiPlayer = false;
        private MultiPlayer Network;
        // function to enable multiplayer
        public void setMultiplayer(MultiPlayer Network)
        {
            this.Network = Network;
            this.multiPlayer = true;
        }
        // function to close game
        public void closeGame()
        {
            MessageBox.Show("The game has ended");
            Application.Exit();

        }
        private void start()
        {
            //soundPlayer.Stop();
            // run if not multiplayer or if host said to go
            if (!multiPlayer)
            {
                opp1Alive = true;
                if (this.threePlayer)
                    opp2Alive = true;
                else
                    opp2Alive = false;
                playerAlive = true;
                player.Shutup();
                player.ShowIdle();
                opponent.ShowIdle();
                opponent.SaySmack();
                if (this.threePlayer)
                    opponent2.SaySmack();
                tmrStateMachine.Interval = 3500;
                tmrStateMachine.Enabled = true;
                state = 0;
            }
            else if (Network.isHost)
            {
                opp1Alive = true;
                if (this.threePlayer)
                    opp2Alive = true;
                else
                    opp2Alive = false;
                playerAlive = true;

                Network.sendCommand(0, "showIdle");
                player.ShowIdle();
                Network.sendCommand(1, "showIdle");
                opponent.ShowIdle();

                // make opponents say smakc
                Network.sendCommand(-1, "saySmack");
                opponent.SaySmack();
                if (this.threePlayer)
                    opponent2.SaySmack();

                tmrMultiplayer.Interval = 3500;
                tmrMultiplayer.Enabled = true;
                state = 0;
            }
        }
        public mainGame(Character player, Character opponent)
        {
            InitializeComponent();
            FormManager.openForms.Add(this);

            this.player = player;
            this.opponent = opponent;
            //this.opponent2 = opponent2;;

        }

        public mainGame(MultiPlayer Network, Character player, Character opponent, Character opponent2)
        {
            InitializeComponent();
            FormManager.openForms.Add(this);

            // set variables
            this.Network = Network;
            this.player = player;
            this.opponent = opponent;
            this.opponent2 = opponent2;
            playerName.Text = Network.name;
            name1.Text = Network.opponentName;
            name2.Text = Network.opponentName2;

            this.multiPlayer = true;
            this.threePlayer = true;
        }
        public mainGame(MultiPlayer Network, Character player, Character opponent)
        {
            InitializeComponent();
            FormManager.openForms.Add(this);

            // set variables
            this.Network = Network;
            this.player = player;
            this.opponent = opponent;
            this.multiPlayer = true;
            playerName.Text = Network.name;
            name1.Text = Network.opponentName;
            this.threePlayer = false;
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
            if (SoundManager.currTrack == 0)
            {
                soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music);
            }
            else if (SoundManager.currTrack == 1)
            {
                soundPlayer = new SoundPlayer(Resources.BabyShark);
            }
            else if (SoundManager.currTrack == 2)
            {
                soundPlayer = new SoundPlayer(Resources.ComfortablyNumb);
            }
            soundPlayer.PlayLooping();
            btnDoIt.Visible = false;
            lblOpponent.Visible = false;
            lblPlayer.Visible = false;
            state = -1;

            // start multiplayer loop
            tmrMultiplayer.Interval = 1;
            if (multiPlayer)
                tmrMultiplayer.Enabled = true;

            // set player objects
            this.player.setText(ref lblPlayer);
            this.player.setPic(ref picPlayer);

            this.opponent.setPic(ref picOpponent);
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
                if (threePlayer)
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
                    picPlayer.Visible = true;
                    if (threePlayer)
                        picOpponent2.Visible = true;
                    lblOpponent.Visible = false;
                    if (threePlayer)
                        lblOpponent2.Visible = false;
                    tmrPlayMusicAfterGameOver.Enabled = true;
                    tmrMultiplayer.Interval = 10;
                    tmrStateMachine.Enabled = false;
                    closeGame();
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
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            //check if multiplayer
            if (multiPlayer && !Network.isHost)
            {
                // send that you pulled the trigger
                Network.sendMessage("go");
            }
            else if (multiPlayer && Network.isHost)
            {
                if (player.PullTrigger(Network, 0))
                {
                    state = 3;
                    tmrMultiplayer.Interval = 2200;
                    tmrMultiplayer.Enabled = true;
                }
                else
                {
                    state = 5;
                    tmrMultiplayer.Interval = 1500;
                    tmrMultiplayer.Enabled = true;
                }
            }
            else // single player
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
            //soundPlayer.PlayLooping();
            tmrPlayMusicAfterGameOver.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // main game loop for multiplayer

        public void multiPlayerLoop(object sender, EventArgs e)
        {
            // check for a new command
            if (Network.isHost)
            {
                if (state == 0)
                {
                    Network.sendCommand(-1, "shutUp");
                    opponent.Shutup();
                    if (threePlayer)
                        opponent2.Shutup();
                    // why not talk on second loop
                    player.SaySmack();
                    Network.sendCommand(-2, "saySmack");
                    state = 1;
                }
                else if (state == 1)
                {
                    if ((!threePlayer && (opp1Alive == false || playerAlive == false)) || (threePlayer && (opp1Alive == false && opp2Alive == false) || (playerAlive == false && opp2Alive == false) || (opp1Alive == false && playerAlive == false)))
                    {
                        // end the game
                        Network.sendCommand(-1, "endGame");

                        tmrMultiplayer.Enabled = false;

                        closeGame();
                    }
                    else
                    {
                        Network.sendCommand(-1, "shutUp");
                        Network.sendCommand(-2, "shutUp");
                        opponent.Shutup();
                        if (threePlayer)
                            opponent2.Shutup();
                        player.Shutup();

                        player.ShowReady();
                        Network.sendCommand(0, "showReady");

                        opponent.ShowNoWeapon();
                        if (threePlayer)
                            opponent2.ShowNoWeapon();
                        Network.sendCommand(1, "showNoWeapon");
                        Network.sendCommand(2, "showNoWeapon");

                        btnDoIt.Visible = true;
                        tmrMultiplayer.Enabled = false;
                        state = 2;
                    }
                }
                else if (state == 3)
                {
                    player.SayOw();
                    Network.sendCommand(0, "sayOw");
                    state = 4;
                    tmrMultiplayer.Interval = 2500;
                }
                else if (state == 4)
                {
                    player.SayBoned();
                    Network.sendCommand(0, "sayBoned");
                    playerAlive = false;
                    Network.sendCommand(0, "hide");
                    picPlayer.Visible = false;

                    state = 1;
                }
                else if (state == 5)
                {
                    if (opp1Alive == true)
                    {
                        player.Shutup();
                        Network.sendCommand(0, "shutUp");

                        opponent.ShowReady();
                        Network.sendCommand(1, "showReady");
                        state = 6;
                    }
                    else
                    {
                        state = 10;
                    }
                }
                else if (state == 6)
                {
                    // tell user its their turn
                    Network.sendCommand(1, "turn");
                    // wait for the user to pull the trigger
                    if (Network.pulledTrigger())
                    {
                        if (opponent.PullTrigger(Network, 1))
                        {
                            state = 7;
                        }
                        else
                        {
                            state = 10;
                        }
                    }
                }
                else if (state == 7)
                {
                    opponent.SayOw();
                    Network.sendCommand(1, "sayOw");
                    state = 8;
                    tmrMultiplayer.Interval = 2500;
                }
                else if (state == 8)
                {
                    opponent.SayBoned();
                    Network.sendCommand(2, "sayBoned");
                    opp1Alive = false;
                    picOpponent.Visible = false;
                    Network.sendCommand(1, "hide");
                    state = 10;
                }
                else if (state == 10)
                {
                    if (opp2Alive == true)
                    {
                        opponent.Shutup();
                        Network.sendCommand(2, "shutUp");
                        if (threePlayer)
                        {
                            opponent2.ShowReady();
                            Network.sendCommand(2, "showReady");
                        }
                        state = 11;
                    }
                    else
                    {
                        state = 1;
                    }
                }
                else if (state == 11)
                {
                    // tell user its their turn
                    Network.sendCommand(2, "turn");
                    // wait for the user to pull the trigger
                    if (Network.pulledTrigger())
                    {
                        if (opponent2.PullTrigger(Network, 1))
                        {
                            state = 12;
                        }
                        else
                        {
                            state = 1;
                        }
                    }
                }
                else if (state == 12)
                {
                    opponent2.SayOw();
                    Network.sendCommand(2, "sayOw");
                    state = 13;
                    tmrMultiplayer.Interval = 2500;
                }
                else if (state == 13)
                {
                    opponent2.SayBoned();
                    Network.sendCommand(2, "sayBonned");
                    opp2Alive = false;
                    picOpponent2.Visible = false;

                    Network.sendCommand(2, "hide");
                    state = 1;
                }
            }
            else
            {
                // get a command from the server
                string rawData = Network.getCurrentCommand();

                if (rawData == null || lastCommand.Equals(rawData))
                {
                    return;
                }
                else
                {
                    lastCommand = rawData;
                }
                var data = (rawData.Split((char)127));
                // select the right player
                Character player = this.player;
                int playerId = int.Parse(data[0]);
                if (playerId == -1)
                {
                    player = null;
                }
                else if (playerId == -2)
                {
                    player = this.player;
                }
                else if (playerId == Network.id)
                {
                    player = this.player;
                }
                else if (playerId == Network.OpponentId)
                {
                    player = opponent;
                }
                else if (playerId == Network.OpponentId2)
                {
                    player = opponent2;
                }

                // do the command
                switch (data[1])
                {
                    case "showIdle":
                        {
                            if (player != null)
                                player.ShowIdle();
                            else
                            {
                                opponent.ShowIdle();
                                if (threePlayer)
                                {
                                    opponent2.ShowIdle();
                                }
                            }
                            break;
                        }
                    case "saySmack":
                        {
                            if (player != null)
                                player.SaySmack();
                            else
                            {
                                opponent.SaySmack();
                                if (threePlayer)
                                {
                                    opponent2.SaySmack();
                                }
                            }
                            break;
                        }
                    case "shutUp":
                        {
                            if (player != null)
                                player.Shutup();
                            else
                            {
                                opponent.Shutup();
                                if (threePlayer)
                                {
                                    opponent2.Shutup();
                                }
                            }
                            break;
                        }
                    case "sayOw":
                        {
                            if (player != null)
                                player.SayOw();
                            break;
                        }
                    case "sayBoned":
                        {
                            if (player != null)
                                player.SayBoned();
                            break;
                        }
                    case "showReady":
                        {
                            if (player != null)
                                player.ShowReady();
                            else
                            {
                                opponent.ShowReady();
                                if (threePlayer)
                                {
                                    opponent2.ShowReady();
                                }
                            }
                            break;
                        }
                    case "turn":
                        {
                            if (player == this.player)
                            {
                                btnDoIt.Enabled = true;
                                btnDoIt.Visible = true;
                            }
                            break;
                        }
                    case "takingTurn":
                        {
                            player.PullTrigger();
                            if (data[2] == "true")
                            {
                                player.ShowKill();
                                player.SayGunWentOff();
                            }
                            else
                            {
                                player.ShowNoWeapon();
                                player.SaySurvived();
                            }
                            break;
                        }
                    case "takeTurn":
                        {
                            break;
                        }
                    case "endGame":
                        {

                            closeGame();
                            break;
                        }
                    case "hide":
                        {
                            player.pic.Visible = false;
                            break;
                        }
                    case null: { break; }
                }
            }

        }
    }
}