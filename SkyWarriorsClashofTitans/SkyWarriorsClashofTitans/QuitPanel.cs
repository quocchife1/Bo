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
    public partial class QuitPanel : Form
    {
        SoundPlayer hoverSound;
        SoundPlayer clickSound;
        public QuitPanel()
        {
            InitializeComponent();
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

        private void btn_no_hover(object sender, EventArgs e)
        {
            playHoverSound();
            btnNo.Image = Properties.Resources.no_hover;
        }

        private void btn_yes_hover(object sender, EventArgs e)
        {
            playHoverSound();
            btnYes.Image = Properties.Resources.yes_hover;
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.Image = Properties.Resources.YesBtn__1_;
        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {
            btnNo.Image = Properties.Resources.NoBtn;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            playClickSound();
            Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            playClickSound();
            this.Close();
        }
    }
}
