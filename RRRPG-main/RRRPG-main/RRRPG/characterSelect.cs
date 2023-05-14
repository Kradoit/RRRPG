using Microsoft.VisualBasic.Devices;
using RRRPG.Properties;
using RRRPGLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace RRRPG
{
    public partial class CharacterSelect : Form
    {
        private SoundPlayer soundPlayer;
        private Character player;
        private Character opponent;
        private Character opponent2;
        private Weapon weapon;
        private Dictionary<WeaponType, (PictureBox pic, Label lbl)> weaponSelectMap;
        private Dictionary<WeaponType, (PictureBox pic, Label lbl)> weaponSelectMap2;

        private int selectedPlayer = 2;
        private bool multiplayer = false;
        private MultiPlayer Network;


        // base init without mutiplayer
        public CharacterSelect()
        {
            InitializeComponent();
            FormManager.openForms.Add(this);

            // add click buttons
            picPlayer.MouseClick += selectPlayer;
            picOpponent2.MouseClick += selectOpponent2;
            picOpponent.MouseClick += selectOpponent;
        }
        // init with multiplayer 
        public CharacterSelect(MultiPlayer Network)
        {
            InitializeComponent();

            // save the network values
            this.Network = Network;
            this.multiplayer = true;
        }
        private void FrmMain2_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music);
            soundPlayer.PlayLooping();
            weapon = Weapon.MakeWeapon(WeaponType.MAGIC_WAND);
            weaponSelectMap = new() {
            {WeaponType.BOW, (picWeaponSelectBow, lblWeaponSelectBow) },
            {WeaponType.CORK_GUN, (picWeaponSelectCorkGun,lblWeaponSelectCorkGun) },
            {WeaponType.WATER_GUN, (picWeaponSelectWaterGun, lblWeaponSelectWaterGun) },
            {WeaponType.MAGIC_WAND, (picWeaponSelectMagicWand, lblWeaponSelectMagicWand) },
            {WeaponType.NERF_REVOLVER, (picWeaponSelectNerfRev, lblWeaponSelectNerfRev) },
            };
            // make multiplayer edits
            if (multiplayer)
            {
                // set the text to not be visible
                player1.Text = "";
                text3.Text = "";
                // run the host event handeler if host
                if (this.Network.isHost)
                {
                    hostStateMachine.Enabled = true;
                    //MultiPlayer.hostListener(ref Network, ref picOpponent, ref picOpponent2, ref player1, ref text3);
                }
            }
            text3.Text = "--------";
            // run the network thread
            //if (multiplayer)
            //text3.Text = "--------";
            //hostStateMachine.Enabled = true;
            //this.Network.networkThread.startLobby(ref Network, ref picOpponent, ref picOpponent2, ref lblOpponentSpeak, ref text3);

        }


        private void SelectWeapon(WeaponType type)
        {
            Color selectedColor = Color.Yellow;
            foreach (var weaponSel in weaponSelectMap)
            {
                weaponSel.Value.pic.BackColor = Color.Black;
                weaponSel.Value.pic.BorderStyle = BorderStyle.None;
                weaponSel.Value.lbl.ForeColor = Color.White;
            }
            weaponSelectMap[type].pic.BackColor = selectedColor;
            weaponSelectMap[type].pic.BorderStyle = BorderStyle.Fixed3D;
            weaponSelectMap[type].lbl.ForeColor = selectedColor;

            weapon = Weapon.MakeWeapon(type);

            // check which box is active
            switch (this.selectedPlayer)
            {
                case 2:
                    {
                        this.player = Character.MakeOpponent(type, picPlayer);
                        this.player.ShowNoWeapon();
                    }
                    break;
                case 1:
                    {
                        this.opponent = Character.MakeOpponent(type, picOpponent);
                        this.opponent.ShowNoWeapon();
                    }
                    break;
                case 3:
                    {
                        this.opponent2 = Character.MakeOpponent(type, picOpponent2);
                        this.opponent2.ShowNoWeapon();
                    }
                    break;
            }
        }

        private void picWeaponSelectMagicWand_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.MAGIC_WAND);
        }

        private void picWeaponSelectCorkGun_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.CORK_GUN);
        }

        private void picWeaponSelectWaterGun_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.WATER_GUN);
        }

        private void picWeaponSelectNerfRev_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.NERF_REVOLVER);
        }

        private void picWeaponSelectBow_Click(object sender, EventArgs e)
        {
            SelectWeapon(WeaponType.BOW);
        }

        private void FrmMain2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.openForms.Remove(this);
            FormManager.CloseAll();
        }


        private void lblPlayerSpeak_Click(object sender, EventArgs e)
        {
        }
        private void setBorder(PictureBox box)
        {
            foreach (var pic in Controls)
            {
                if (pic.GetType() == typeof(PictureBox))
                {
                    var pic2 = (PictureBox)pic;
                    pic2.BackColor = Color.Black;
                }
            }
            box.BackColor = Color.Yellow;
        }
        // functions to select which character to select
        private void selectPlayer(object sender, EventArgs e)
        {
            selectedPlayer = 2;
            var picBox = (PictureBox)sender;
            setBorder(picBox);
        }
        private void selectOpponent(object sender, EventArgs e)
        {
            selectedPlayer = 1;
            var picBox = (PictureBox)sender;
            setBorder(picBox);
        }
        private void selectOpponent2(object sender, EventArgs e)
        {
            selectedPlayer = 3;
            var picBox = (PictureBox)sender;
            setBorder(picBox);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResourcesRef.Resources = Resources.ResourceManager;
            mainGame MainGame;
            Hide();

            if (multiplayer)
            {
                if (player == null)
                {
                    MessageBox.Show("You must choose a character");
                    return;
                }

                MainGame = new mainGame(player, Network);

                soundPlayer.Stop();
                MainGame.ShowDialog();
                FormManager.openForms.Add(MainGame);
            }
            else
            {
                // check that they have at least a player and a opponent

                if (opponent == null)
                {
                    MessageBox.Show("You must choose an opponent");
                    return;
                }

                // check if its one or two player
                if (opponent2 == null)
                    MainGame = new mainGame(player, opponent);
                else
                    MainGame = new mainGame(player, opponent, opponent2);


                if (multiplayer)
                {
                    MainGame.setMultiplayer(Network);
                };

                soundPlayer.Stop();
                MainGame.ShowDialog();
                FormManager.openForms.Add(MainGame);
            }
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.openForms.Remove(this);
            FormManager.CloseAll();
        }

        // host function
        private void host(object sender, EventArgs e)
        {
            text3.Text = "123123";
            Network.checkForUsers(ref player1, ref text3);
        }
        private void checkForData(object sender, EventArgs e)
        {
            // check for data
            Network.checkForData(ref player1, ref text3, ref opponent, ref opponent2);

            // set the labels
            opponent.setPic(ref picOpponent);
            opponent2.setPic(ref picOpponent2);

        }
    }

}
