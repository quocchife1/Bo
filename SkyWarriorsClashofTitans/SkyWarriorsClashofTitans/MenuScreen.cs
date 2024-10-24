using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SkyWarriorsClashofTitans
{
    public partial class MenuScreen : Form
    {
        WindowsMediaPlayer snd;
        public MenuScreen()
        {
            InitializeComponent();
            //MenuScreen_Load();
            //wplayer.URL = (@"D:\Github\Winforms\Sound\IAmaRobot.wav");
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

        private void playaudio(object sender, EventArgs e)
        {
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Path.Combine(basePath, @"./../../IAmaRobot.wav");
            player.Load();
            player.Play();
        }

        private void btn_play_MouseHover(object sender, EventArgs e)
        {
            btn_play.Image = Properties.Resources.play_hover;
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE2.wav");
            //sound.Play();
        }

        private void btn_shop_MouseHover(object sender, EventArgs e)
        {
            btn_shop.Image = Properties.Resources.shop_hover;
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE2.wav");
            //sound.Play();
        }
        private void btn_settings_MouseHover(object sender, EventArgs e)
        {
            btn_settings.Image = Properties.Resources.settings_hover;
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE2.wav");
            //sound.Play();
        }

        private void btn_quit_MouseHover(object sender, EventArgs e)
        {
            btn_quit.Image = Properties.Resources.quit_hover;
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE2.wav");
            //sound.Play();
        }

        private void btn_play_MouseLeave(object sender, EventArgs e)
        {
            btn_play.Image= Properties.Resources.PlayBtn;
        }

        private void btn_shop_MouseLeave(object sender, EventArgs e)
        {
            btn_shop.Image = Properties.Resources.ShopBtn;
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
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE1.wav");
            //sound.Play();
            GameScreen gamePlay = new GameScreen();
            gamePlay.ShowDialog();
        }

        private void btn_shop_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE1.wav");
            //sound.Play();
            ShopScreen shopscreen = new ShopScreen();
            shopscreen.ShowDialog();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE1.wav");
            //sound.Play();
            QuitPanel quitPanel = new QuitPanel();
            quitPanel.ShowDialog();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Github\Winforms\Sound\SE1.wav");
            //sound.Play();
            SettingScreen setting = new SettingScreen();
            setting.ShowDialog();
        }
    }
}
