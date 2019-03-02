using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Packaging;
using System.Collections;

namespace DataLoadLibrary
{
    public class LoadExcelFile
    {
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
                        if(c.InnerText != "")
                        {
                            if(c.DataType == null)
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
                    else if(cellValues.Count > 1)
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
