﻿using System.Collections.Generic;
using System.Linq;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Packaging;
using System.Collections;
using Vanguard.Models;
using System;

namespace ExcelDataImporter
{
    public class LoadExcelFile
    {

        public void LoadAllTabs(string filePath)
        {
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filePath, true))
            {
                GetDbVersionNumber(doc, 4);
                GetWeapons(doc, 5);
                GetPlotArmor(doc, 6);
            }

        }

        private int GetDbVersionNumber(SpreadsheetDocument doc, int dbTab)
        {
            return 0;
        }

        private List<Row> ReadFromSheet(SpreadsheetDocument doc, int dbTab)
        {
            WorkbookPart workbookPart = doc.WorkbookPart;
            var stringTablePart = workbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();
            WorksheetPart worksheetPart = workbookPart.WorksheetParts.ElementAt(dbTab);
            SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
            ArrayList data = new ArrayList();
            List<Row> rows = sheetData.Elements<Row>().ToList();
            rows.RemoveAt(0); //skips header
            return rows;
        }

        public List<WeaponModel> GetWeapons(SpreadsheetDocument doc, int dbTab)
        {
            List<WeaponModel> weaponList = new List<WeaponModel>();
            var rows = ReadFromSheet(doc, dbTab);

            foreach (Row r in rows)
            {
                WeaponModel weapon = new WeaponModel();
                weapon.Name = r.ElementAt(0).ToString();
                weapon.WeaponPointCost = r.InnerText.ElementAt(2);
                weapon.TargetNumberMelee = r.InnerText.ElementAt(3);
                //   if (enum.TryParse(r.ElementAt(1), out string weap)){
                //       weapon.Category = weap;
                //   }
                //   else
                //{
                //       Console.WriteLine("There was an issue loading in weapon categories.");
                //}

                weaponList.Add(weapon);
            }
            return weaponList;
        }

        public Dictionary<int, int> GetPlotArmor(SpreadsheetDocument doc, int dbTab)
        {
            Dictionary<int, int> PlotArmor = new Dictionary<int, int>();

            ReadFromSheet(doc, dbTab);


            return null;
        }

        public string myVar = "hello" + ;


        public List<Trait> GetTraits(string filePath)
        {
            List<Trait> traitList = new List<Trait>();
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filePath, true))
            {
                WorkbookPart workbookPart = doc.WorkbookPart;

                var stringTablePart = workbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();

                WorksheetPart worksheetPart = workbookPart.WorksheetParts.ElementAt(2); // This is the "Traits" tab;
                SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

                ArrayList data = new ArrayList();

                List<Row> rows = sheetData.Elements<Row>().ToList();

                rows.RemoveAt(0);

                string category = "";

                foreach (Row r in rows)
                {
                    Trait relevantTrait = new Trait();
                    List<string> cellValues = new List<string>();
                    foreach (Cell c in r.Elements<Cell>())
                    {
                        if (c.InnerText != "")
                        {
                            if (c.DataType == null)
                            {
                                cellValues.Add(c.InnerText);
                            }
                            else
                            {
                                cellValues.Add(stringTablePart.SharedStringTable.ElementAt(int.Parse(c.InnerText)).InnerText);
                            }
                        }
                    }
                    if (cellValues.Count == 1)
                    {
                        category = cellValues.ElementAt(0);
                    }
                    else if (cellValues.Count > 1)
                    {
                        relevantTrait.category = category;
                        relevantTrait.traitName = cellValues.ElementAt(0);
                        relevantTrait.costInD = cellValues.ElementAt(1);
                        relevantTrait.description = cellValues.ElementAt(2);
                        traitList.Add(relevantTrait);
                    }
                }
            }
            return traitList;
        }
    }
}
