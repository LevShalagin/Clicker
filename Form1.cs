using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Clicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonStart.Visible = true;
            buttonClick.Visible = false;
            toolTipExit.SetToolTip(buttonExit, "Exit");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            Clicks.AddClick();
            labelAmount.Text = "Clicks1: " + Clicks.clicks;
            buttonStart.Visible = false;
            buttonClick.Visible = true;
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            Clicks.AddClick();
            labelAmount.Text = "Clicks: " + Clicks.clicks;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
