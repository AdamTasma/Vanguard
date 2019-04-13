using Vanguard.Models;
using Vanguard.DataImport;
using System.Collections.Generic;
using System;

namespace Vanguard
{
    public class LoadExcelFile
    {
        public DataBase LoadAllTabs()
        {
            List<string> errorList = new List<string>();
            errorList.Add("test");

            //Db Glossary
            int versionTab = 5;
            int weaponsTab = 7;

            DataBase dataBase = new DataBase();

            (dataBase.DbVersion, errorList) = LoadDbVersion(errorList, versionTab);
            dataBase.WeaponsDB = LoadWeaponsDb(errorList, weaponsTab);

            return dataBase;
        }

        public Tuple<string, List<string>> LoadDbVersion(List<string> errorList, int tab)
        {
            Excel excel = new Excel(tab);
            int row = 2;
            int column = 1;
            string dbVersion = "";
            try
            {
                dbVersion = excel.ReadCell(row, column);
            }
            catch(Exception)
            {
                errorList.Add($"There was an issue retrieving the Database Version at tab: {tab}, row: {row}, column: {column}.");
            }

            excel.Close();

            return new Tuple<string, List<string>>(dbVersion, errorList);
        }

        public List<WeaponModel> LoadWeaponsDb(List<string> errorList, int tab)
        {
            List<WeaponModel> WeaponsList = new List<WeaponModel>();
            Excel excel = new Excel(tab);

            var weapons = excel.GetRows();
            weapons.RemoveAt(0); //remove the headers

            foreach(var weapon in weapons)
            {
                WeaponModel wm = new WeaponModel
                {
                    Name = weapon[0],
                    //string myString = weapon[1];
                    //wm.Category = "Melee";
                    //bool myBool = Enum.TryParse(myString, out wm.Category);
                    //Enum.TryParse(weapon[1], out wm.Category);
                    //Enum.Parse(typeof(WeaponCategoryEnum), weapon[1]);
                    //bool myBool = Enum.TryParse(typeof(WeaponCategoryEnum), weapon[1]);
                    WeaponPointCost = int.Parse(weapon[2]),
                    TargetNumberMelee = int.Parse(weapon[3]),
                    TargetNumberShort = int.Parse(weapon[4]),
                    TargetNumberMedium = int.Parse(weapon[5]),
                    TargetNumberLong = int.Parse(weapon[6]),
                    //Notes = weapon[7]
                };

                WeaponsList.Add(wm);
            }

            excel.Close();

            return WeaponsList;
        }
    }
}
