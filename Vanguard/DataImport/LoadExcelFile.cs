using Vanguard.Models;
using Vanguard.DataImport;
using System.Collections.Generic;
using System;
using static Vanguard.Models.WeaponCategoryEnum;
using static Vanguard.Models.ArmorDieTypeEnum;

namespace Vanguard
{
    public class LoadExcelFile
    {
        //Db Glossary
        public int versionTab = 5;
        public int weaponsTab = 7;
        public int armorTab = 8;

        /// <summary>
        /// Loads all the sheets from the excel database workbook "VanguardDb.xlsx" and passes along any database integrity issues."
        /// </summary>
        public (DataBase, List<string>) LoadAllTabs()
        {
            List<string> errorList = new List<string>();

            DataBase dataBase = new DataBase();

            (dataBase.DbVersion, errorList) = LoadDbVersion(errorList, versionTab);
            (dataBase.WeaponsDB, errorList) = LoadWeaponsDb(errorList, weaponsTab);
            (dataBase.ArmorDB, errorList) = LoadArmorDb(errorList, armorTab);

            return (dataBase, errorList);
        }

        public (string, List<string>) LoadDbVersion(List<string> errorList, int tab)
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
                errorList.Add($"Database Version issue at tab: {tab}, row: {row}, column: {column}.");
            }

            excel.Close();
            return (dbVersion, errorList);
        }

        public (List<WeaponModel>, List<string>) LoadWeaponsDb(List<string> errorList, int tab)
        {
            List<WeaponModel> WeaponsList = new List<WeaponModel>();
            Excel excel = new Excel(tab);

            var weapons = excel.GetRows();
            weapons.RemoveAt(0); //removes the headers row
            int row = 0;

            foreach(var weapon in weapons)
            {
                row++;
                int column = 0;
                WeaponModel wm = new WeaponModel();

                try
                {
                    column++;
                    wm.Name = weapon[0];
                    column++;
                    wm.Category = (WeaponCategory)Enum.Parse(typeof(WeaponCategory), weapon[1]);
                    column++;
                    wm.WeaponPointCost = int.Parse(weapon[2]);
                    column++;
                    wm.TargetNumberMelee = int.Parse(weapon[3]);
                    column++;
                    wm.TargetNumberShort = int.Parse(weapon[4]);
                    column++;
                    wm.TargetNumberMedium = int.Parse(weapon[5]);
                    column++;
                    wm.TargetNumberLong = int.Parse(weapon[6]);
                    column++;
                    if(weapon.Count == 8)
                    {
                        wm.Notes = weapon[7];
                    }
                }
                catch (Exception ex)
                {
                    errorList.Add($"Weapon issue at tab: {tab}, row: {row}, column: {column}.");
                }

                WeaponsList.Add(wm);
            }

            excel.Close();
            return (WeaponsList, errorList);
        }

        public (List<ArmorModel>, List<string>) LoadArmorDb(List<string> errorList, int tab)
        {
            List<ArmorModel> ArmorList = new List<ArmorModel>();

            Excel excel = new Excel(tab);

            var armors = excel.GetRows();
            armors.RemoveAt(0); //removes the headers row
            int row = 0;

            foreach(var armor in armors)
            {
                row++;
                int column = 0;
                ArmorModel am = new ArmorModel();

                try
                {
                    column++;
                    am.ArmorDieType = (ArmorType)Enum.Parse(typeof(ArmorType), armor[0]); 
                    column++;
                    am.DieAmount = int.Parse(armor[1]);
                    column++;
                    am.PointCost = int.Parse(armor[2]);
                }
                catch(Exception ex)
                {
                    errorList.Add($"Armor issue at tab: {tab}, row: {row}, column: {column}.");
                }

                ArmorList.Add(am);
            }

            excel.Close();
            return (ArmorList, errorList);
        }
    }
}
