using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vanguard.Forms
{
    public partial class Vanguard : Form
    {
        public Vanguard()
        {
            InitializeComponent();
        }

        private void Vanguard_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnP1Next_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.BringToFront();
            panel2.Visible = true;
        }

        private void btnP2Previous_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
            panel2.Hide();
        }

        private void btnP2Next_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Show();
            panel3.BringToFront();
        }

        private void btnP3Previous_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel2.BringToFront();
            panel3.Hide();
        }
    }
}
