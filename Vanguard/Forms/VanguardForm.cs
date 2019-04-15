using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vanguard.Models;

namespace Vanguard.Forms
{
    public partial class VanguardForm : Form
    {
        public VanguardForm()
        {
            InitializeComponent();

            MapDbToMemory();
        }

        private DataBase MapDbToMemory()
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
                    errorMessage = errorMessage + "\n" + error;
                }

                MessageBox.Show(errorMessage);
            }
            else
            {
                //MessageBox.Show("Database import successful.");
            }
            return data;
        }

        private void VanguardForm_Load(object sender, EventArgs e)
        {
            creatorControlForm1.Hide();
            savedCharactersControlForm1.Hide();
        }

        private void CreateCharacterBtn_Click(object sender, EventArgs e)
        {
            creatorControlForm1.Show();
            savedCharactersControlForm1.Hide();
        }

        private void SavedCharacterListBtn_Click(object sender, EventArgs e)
        {
            savedCharactersControlForm1.Show();
            creatorControlForm1.Hide();
        }
    }
}
