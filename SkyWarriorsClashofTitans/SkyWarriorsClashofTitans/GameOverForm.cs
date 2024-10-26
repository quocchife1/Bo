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
    public partial class GameOverForm : Form
    {
        public GameOverForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        public void SetScore(int score)
        {
            lblScore.Text = "Score: " + score.ToString();
        }


        private void GameOverForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
