﻿using System;
using System.Windows.Forms;

namespace Vanguard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListOfThings_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ListOfThings.GetItemText(ListOfThings.SelectedItem);
            MessageBox.Show(text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = NameInput.Text;
            String address = AddressInput.Text;

            MessageBox.Show(name + address);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
