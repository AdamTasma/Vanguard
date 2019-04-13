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
            DataBase dataBase = new DataBase
            {
                DbVersion = LoadDbVersion(),
                WeaponsDB = LoadWeaponsDb()
            };

            return dataBase;
        }

        public string LoadDbVersion()
        {
            Excel excel = new Excel(5);
              
            var dbVersion = excel.ReadCell(2,1);
            excel.Close();

            return dbVersion;
        }

        public List<WeaponModel> LoadWeaponsDb()
        {
            List<WeaponModel> WeaponsList = new List<WeaponModel>();
            Excel excel = new Excel(7);

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


            return WeaponsList;
        }
    }
}
