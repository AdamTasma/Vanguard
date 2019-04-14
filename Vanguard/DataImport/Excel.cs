using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace Vanguard.DataImport
{
    public class Excel
    {
        public string filePath = "D:\\repos\\Vanguard\\ExcelFileFolder\\VanguardDB.xlsx";

        _Application excel = new Application();
        Workbook wb;
        Worksheet ws;

        public Excel(int sheet)
        {
            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[sheet];
        }

        public string ReadCell(int row, int column)
        {
            if (ws.Cells[row, column] != null)
            {
                var myValue = ws.Cells[row, column].Value2;
                return myValue;
            }
            else
            {
                return "";
            }
        }

        public List<List<string>> GetRows()
        {
            List<List<string>> rows = new List<List<string>>();

            int row = 0;
            int column = 0;

            int i = 0;
            int j = 0;

            while (i == 0) //iterates through rows
            {
                row++;

                j = 0;
                column = 0;

                if (ws.Cells[row, column + 1].value2 != null)
                {
                    var currentRow = new List<string>();

                    while (j == 0) //iterates through all the columns 
                    {
                        column++;

                        if (ws.Cells[row, column].value2 != null)
                        {
                            string cellValue = ws.Cells[row, column].Value2.ToString();
                            currentRow.Add(cellValue);
                        }
                        else
                        {
                            j = 1;
                        }
                    }

                    rows.Add(currentRow);
                }
                else
                {
                    i = 1;
                }
            }

            return rows;
        }

        public void Close()
        {
            wb.Close();
        }

        public void UnprotectSheet()
        {
            ws.Unprotect();
        }
    }
}
