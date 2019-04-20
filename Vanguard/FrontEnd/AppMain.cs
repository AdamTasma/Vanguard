using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vanguard.Models;

namespace Vanguard.FrontEnd
{
    public partial class AppMain : Form
    {
        DataBase data;

        public AppMain()
        {
            InitializeComponent();
            data = MapDbToMemory();
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

        private void AppMain_Load(object sender, EventArgs e)
        {

            DbVersionLbl.Text = "DbVersion: " + data.DbVersion;
            characterCreationUC1.Hide();
            savedCharactersUC1.Hide();
        }

        private void newCharacterBtn_Click(object sender, EventArgs e)
        {
            characterCreationUC1.Show();
            savedCharactersUC1.Hide();
        }

        private void savedCharacterBtn_Click(object sender, EventArgs e)
        {
            characterCreationUC1.Hide();
            savedCharactersUC1.Show();
        }
    }
}
