using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using Vanguard.Models;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace DataImporter
{
    public class ImportDataFromExcelFile
    {
        public void LoadAllTabs(string filePath)
        {
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filePath, false))
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

        public string GetDbVersionNumberDebug(string filePath, int dbTab)
        {
            using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filePath, false))
            {
                var stringTablePart = workbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();

                string versionNumber = "";
                var rows = ReadFromSheet(doc, dbTab);
                //var versionNumber = rows[1].ElementAt(0).InnerText.ToString();


                List<string> cellValues = new List<string>();
                foreach (Cell c in rows[0].Elements<Cell>())
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


                //            foreach (Cell c in r.Elements<Cell>())
                //            {
                //                if (c.InnerText != "")
                //                {
                //                    if (c.DataType == null)
                //                    {
                //                        cellValues.Add(c.InnerText);
                //                    }
                //                    else
                //                    {
                //                        cellValues.Add(stringTablePart.SharedStringTable.ElementAt(int.Parse(c.InnerText)).InnerText);
                //                    }
                //                }
                //            }
                //            if (cellValues.Count == 1)
                //            {
                //                category = cellValues.ElementAt(0);
                //            }
                //            else if (cellValues.Count > 1)
                //            {
                //                relevantTrait.Category = category;
                //                relevantTrait.Cost = cellValues.ElementAt(0);
                //                relevantTrait.costInD = cellValues.ElementAt(1);
                //                relevantTrait.description = cellValues.ElementAt(2);
                //                traitList.Add(relevantTrait);
                //            }


                //versionNumber = rows[0].Elements<Cell>().inner;

                return versionNumber;
            }
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

        //public List<CreatureTrait> GetTraits(string filePath)
        //{
        //    List<CreatureTrait> traitList = new List<CreatureTrait>();
        //    using (SpreadsheetDocument doc = SpreadsheetDocument.Open(filePath, true))
        //    {
        //        WorkbookPart workbookPart = doc.WorkbookPart;

        //        var stringTablePart = workbookPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();

        //        WorksheetPart worksheetPart = workbookPart.WorksheetParts.ElementAt(2); // This is the "Traits" tab;
        //        SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

        //        ArrayList data = new ArrayList();

        //        List<Row> rows = sheetData.Elements<Row>().ToList();

        //        rows.RemoveAt(0);

        //        string category = "";

        //        foreach (Row r in rows)
        //        {
        //            CreatureTrait relevantTrait = new CreatureTrait();
        //            List<string> cellValues = new List<string>();
        //            foreach (Cell c in r.Elements<Cell>())
        //            {
        //                if (c.InnerText != "")
        //                {
        //                    if (c.DataType == null)
        //                    {
        //                        cellValues.Add(c.InnerText);
        //                    }
        //                    else
        //                    {
        //                        cellValues.Add(stringTablePart.SharedStringTable.ElementAt(int.Parse(c.InnerText)).InnerText);
        //                    }
        //                }
        //            }
        //            if (cellValues.Count == 1)
        //            {
        //                category = cellValues.ElementAt(0);
        //            }
        //            else if (cellValues.Count > 1)
        //            {
        //                relevantTrait.Category = category;
        //                relevantTrait.Cost = cellValues.ElementAt(0);
        //                relevantTrait.costInD = cellValues.ElementAt(1);
        //                relevantTrait.description = cellValues.ElementAt(2);
        //                traitList.Add(relevantTrait);
        //            }
        //        }
        //    }
        //    return traitList;
        //}
    }
}
