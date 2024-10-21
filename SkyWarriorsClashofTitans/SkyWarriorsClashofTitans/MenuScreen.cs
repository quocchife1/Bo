using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SkyWarriorsClashofTitans
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
            MenuScreen_Load();
            wplayer.URL = (@"D:\WinForm\Fighter Jet\Sound\IAmaRobot.wav");
            wplayer.controls.play();
        }

        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        #region Full screen
        private void MenuScreen_Load()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_play_MouseHover(object sender, EventArgs e)
        {
            btn_play.Image = Properties.Resources.play_hover;
        }

        private void btn_settings_MouseHover(object sender, EventArgs e)
        {
            btn_settings.Image = Properties.Resources.settings_hover;
        }

        private void btn_quit_MouseHover(object sender, EventArgs e)
        {
            btn_quit.Image = Properties.Resources.quit_hover;
        }

        private void btn_play_MouseLeave(object sender, EventArgs e)
        {
            btn_play.Image= Properties.Resources.PlayBtn;
        }

        private void btn_settings_MouseLeave(object sender, EventArgs e)
        {
            btn_settings.Image= Properties.Resources.SettingsBtn;
        }

        private void btn_quit_MouseLeave(object sender, EventArgs e)
        {
            btn_quit.Image= Properties.Resources.QuitBtn;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            //menuPanel.Hide();
            Form1 gamePlay = new Form1();
            gamePlay.ShowDialog();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            QuitPanel quitPanel = new QuitPanel();
            quitPanel.ShowDialog();
        }
    }
}
