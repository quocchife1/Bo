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
            btnNo.Image = Properties.Resources.no_hover;
        }

        private void btn_yes_hover(object sender, EventArgs e)
        {
            btnYes.Image = Properties.Resources.yes_hover;
        }
    }
}
