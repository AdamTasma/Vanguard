using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vanguard;
using Vanguard.Models;

namespace Vanguard.Forms
{
    public partial class Vanguard : Form
    {
        public Vanguard()
        {
            InitializeComponent();

            MapDbToMemory();
        }

        private DataBase MapDbToMemory() //eventually this will load all the db to memory
        {
            LoadExcelFile loadExcelFile = new LoadExcelFile();
            DataBase data;
            List<string> errorList;
            (data, errorList) = loadExcelFile.LoadAllTabs();

            if (errorList.Count > 0)
            {
                string errorMessage = "VanguardDb.xlsx had issues that should be corrected before attempting to use this application. \n";
                foreach (string error in errorList)
                {
                    errorMessage= errorMessage + "\n" + error;
                }

                MessageBox.Show(errorMessage);
            }
            else
            {
                MessageBox.Show("Database import successful.");
            }
            return data;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
