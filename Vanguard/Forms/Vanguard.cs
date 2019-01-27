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
            panel2.Hide();
            panel3.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //https://www.youtube.com/watch?v=5Anto1N_FSs
        }

        private void btnP1Next_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.BringToFront();
            panel2.Show();
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
