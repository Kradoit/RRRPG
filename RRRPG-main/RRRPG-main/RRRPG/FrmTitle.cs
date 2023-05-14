using RRRPG.Properties;
using RRRPGLib;
using System.Media;

namespace RRRPG;

public partial class FrmTitle : Form
{
    private SoundPlayer soundPlayer;
    public FrmTitle()
    {
        InitializeComponent();
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        ResourcesRef.Resources = Resources.ResourceManager;
        Hide();
        CharacterSelect characterSelect = new CharacterSelect();
        characterSelect.ShowDialog();
        FormManager.openForms.Add(characterSelect);
    }
    private void button1_Click(object sender, EventArgs e)
    {
        ResourcesRef.Resources = Resources.ResourceManager;
        Hide();
        multiplayerMenu MultiplayerMenu = new multiplayerMenu();
        MultiplayerMenu.ShowDialog();
        FormManager.openForms.Add(MultiplayerMenu);
    }
    private void buttonSettings_Click(object sender, EventArgs e)
    {
        ResourcesRef.Resources = Resources.ResourceManager;
        Hide();
        settings Settings = new settings();
        Settings.ShowDialog();
        FormManager.openForms.Add(Settings);
    }

    private void FrmTitle_Load(object sender, EventArgs e)
    {
        if (SoundManager.currTrack == 0)
        {
            soundPlayer = new SoundPlayer(Resources.Mus_Title_Bg_Music_3);
            soundPlayer.PlayLooping();
        }
        FormManager.openForms.Add(this);
    }

    private void FrmTitle_FormClosed(object sender, FormClosedEventArgs e)
    {
        FormManager.openForms.Remove(this);
        FormManager.CloseAll();
    }
}
