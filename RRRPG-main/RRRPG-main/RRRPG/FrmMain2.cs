using RRRPG.Properties;
using RRRPGLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FrmMain2 : Form
    {
        private SoundPlayer soundPlayer;
        private int state;
        private Character player;
        private bool playerAlive;
        private Character opponent;
        private bool opp1Alive;
        private Character opponent2;
        private bool opp2Alive;
        private Weapon weapon;
        private Dictionary<WeaponType, (PictureBox pic, Label lbl)> weaponSelectMap;
        private Dictionary<WeaponType, (PictureBox pic, Label lbl)> weaponSelectMap2;

        public FrmMain2()
        {
            InitializeComponent();
            FormManager.openForms.Add(this);
        }
        private void FrmMain2_Load(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music);
            soundPlayer.PlayLooping();
            btnDoIt.Visible = false;
            lblOpponentSpeak.Visible = false;
            lblOpponentSpeak2.Visible = false;
            lblPlayerSpeak.Visible = false;
            weapon = Weapon.MakeWeapon(WeaponType.MAGIC_WAND);
            state = -1;
            weaponSelectMap = new() {
            {WeaponType.BOW, (picWeaponSelectBow, lblWeaponSelectBow) },
            {WeaponType.CORK_GUN, (picWeaponSelectCorkGun,lblWeaponSelectCorkGun) },
            {WeaponType.WATER_GUN, (picWeaponSelectWaterGun, lblWeaponSelectWaterGun) },
            {WeaponType.MAGIC_WAND, (picWeaponSelectMagicWand, lblWeaponSelectMagicWand) },
            {WeaponType.NERF_REVOLVER, (picWeaponSelectNerfRev, lblWeaponSelectNerfRev) },
            };
            SelectWeapon(WeaponType.MAGIC_WAND);
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            if (player.PullTrigger(weapon))
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            opp1Alive = true;
            opp2Alive = true;
            playerAlive = true;
            player.Shutup();
            player.ShowIdle();
            opponent.ShowIdle();
            btnStart.Visible = false;
            opponent.SaySmack();
            opponent2.SaySmack();
            tmrStateMachine.Interval = 3500;
            tmrStateMachine.Enabled = true;
            state = 0;
            panWeaponSelect.Visible = false;
        }

        private void tmrDialog_Tick(object sender, EventArgs e)
        {
            if (state == 0)
            {
                opponent.Shutup();
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
                    opponent2.ShowNoWeapon();
                    picOpponent.Visible = true;
                    picOpponent2.Visible = true;
                    lblOpponentSpeak.Visible = false;
                    lblOpponentSpeak2.Visible = false;
                    btnStart.Visible = true;
                    tmrPlayMusicAfterGameOver.Enabled = true;
                    panWeaponSelect.Visible = true;
                    tmrStateMachine.Enabled = false;
                }
                else
                {
                    opponent.Shutup();
                    opponent2.Shutup();
                    player.Shutup();
                    player.ShowReady();
                    opponent.ShowNoWeapon();
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
                if (opponent.PullTrigger(weapon))
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
                if (opponent2.PullTrigger(weapon))
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
                // TODO: make player not visible
                state = 1;
            }
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
            opponent = Character.MakeOpponent(type, picOpponent, lblOpponentSpeak);
            opponent2 = Character.MakeOpponent(type, picOpponent2, lblOpponentSpeak2);
            player = Character.MakePlayer(type, picPlayer, lblPlayerSpeak);
            opponent2.ShowNoWeapon();
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

        private void tmrPlayMusicAfterGameOver_Tick(object sender, EventArgs e)
        {
            if (btnStart.Visible)
            {
                soundPlayer.PlayLooping();
            }
            tmrPlayMusicAfterGameOver.Enabled = false;
        }
    }

}
