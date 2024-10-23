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
    public partial class ShopScreen : Form
    {
        public ShopScreen()
        {
            InitializeComponent();
            ShopScreen_Load();
        }
        #region Full screen
        private void ShopScreen_Load()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion

        private void btn_play_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\WinForm\Fighter Jet\Sound\SE1.wav");
            sound.Play();
            this.Close();
        }

        private void btn_play_MouseHover(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.Back_hover;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\WinForm\Fighter Jet\Sound\SE2.wav");
            sound.Play();
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.Image = Properties.Resources.BackBtn__2_;
        }
    }
}
