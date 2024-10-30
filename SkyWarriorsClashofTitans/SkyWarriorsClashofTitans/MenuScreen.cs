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
        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        string equipped;
        SoundPlayer hoverSound;
        SoundPlayer clickSound;

        public MenuScreen()
        {
            InitializeComponent();
            wplayer.URL = (@"IAmaRobot.wav");
            wplayer.settings.setMode("loop",true);
            wplayer.controls.play();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }
        }
        private void playHoverSound()
        {
            hoverSound = new SoundPlayer(@"SE2.wav");
            hoverSound.Play();
        }
        private void playClickSound()
        {
            clickSound = new SoundPlayer(@"SE1.wav");
            clickSound.Play();
        }

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
            playHoverSound();
        }

        private void btn_shop_MouseHover(object sender, EventArgs e)
        {
            btn_shop.Image = Properties.Resources.shop_hover;
            playHoverSound();
        }
        private void btn_settings_MouseHover(object sender, EventArgs e)
        {
            btn_settings.Image = Properties.Resources.settings_hover;
            playHoverSound();
        }

        private void btn_quit_MouseHover(object sender, EventArgs e)
        {
            btn_quit.Image = Properties.Resources.quit_hover;
            playHoverSound();
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

        private void ReadFile()
        {
            string filePath = @"Character.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    equipped = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            playClickSound();
            ReadFile();
            int save = int.Parse(equipped);
            GameScreen gameScreen = new GameScreen(save);
            gameScreen.ShowDialog();
        }

        private void btn_shop_Click(object sender, EventArgs e)
        {
            playClickSound();
            ShopScreen shopscreen = new ShopScreen();
            shopscreen.ShowDialog();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            playClickSound();
            QuitPanel quitPanel = new QuitPanel();
            quitPanel.ShowDialog();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            playClickSound();
            SettingScreen setting = new SettingScreen();
            setting.ShowDialog();
        }
    }
}
