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
    public partial class PauseScreen : Form
    {
        public bool IsResume {  get;private set; }
        public PauseScreen()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void PauseScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                IsResume = false;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            IsResume = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void ResumeBtn_MouseHover(object sender, EventArgs e)
        {
            ResumeBtn.Image = Properties.Resources.resume_hover;
        }

        private void ResumeBtn_MouseLeave(object sender, EventArgs e)
        {
            ResumeBtn.Image= Properties.Resources.ResumeBtn;
        }

        private void BackBtn_MouseHover(object sender, EventArgs e)
        {
            BackBtn.Image = Properties.Resources.Back_hover;
        }

        private void BackBtn_MouseLeave(object sender, EventArgs e)
        {
            BackBtn.Image = Properties.Resources.BackBtn__2_;
        }
    }
}
