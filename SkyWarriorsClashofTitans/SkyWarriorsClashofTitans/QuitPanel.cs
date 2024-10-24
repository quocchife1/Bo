using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyWarriorsClashofTitans
{
    public partial class QuitPanel : Form
    {
        public QuitPanel()
        {
            InitializeComponent();
        }

        private void btn_no_hover(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\WinForm\Fighter Jet\Sound\SE2.wav");
            //sound.Play();
            btnNo.Image = Properties.Resources.no_hover;
        }

        private void btn_yes_hover(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\WinForm\Fighter Jet\Sound\SE2.wav");
            //sound.Play();
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
            Application.Exit();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\WinForm\Fighter Jet\Sound\SE1.wav");
            //sound.Play();
            this.Close();
        }
    }
}
