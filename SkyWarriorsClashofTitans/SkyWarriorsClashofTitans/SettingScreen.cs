using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyWarriorsClashofTitans
{
    public partial class SettingScreen : Form
    {
        SoundPlayer hoverSound;
        SoundPlayer clickSound;
        public SettingScreen()
        {
            InitializeComponent();
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

        private void Volume_Scroll(object sender, EventArgs e)
        {
            MenuScreen.wplayer.controls.play();
            MenuScreen.wplayer.settings.volume = Volume.Value;

            int tmp = Volume.Value;

            switch (tmp)
            {
                case 0:
                    MusicPercent.Image = Properties.Resources._0V; 
                    break;
                case 25:
                    MusicPercent.Image = Properties.Resources._25V;
                    break;
                case 50:
                    MusicPercent.Image = Properties.Resources._50V;
                    break;
                case 75:
                    MusicPercent.Image = Properties.Resources._75V;
                    break;
                case 100:
                    MusicPercent.Image = Properties.Resources._100V;
                    break;
                default:
                    break;
            }
        }

        private void btn_back_MouseHover(object sender, EventArgs e)
        {
            playHoverSound();
            btn_back.Image = Properties.Resources.Back_hover;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.BackBtn__2_;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            playClickSound();
            this.Close();
        }
    }
}
