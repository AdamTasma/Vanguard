using System;
using System.Collections.Generic;
using Vanguard.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

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
            row++;
            column++;

            if(ws.Cells[row, column] != null)
            {
                var myValue = ws.Cells[row, column].Value2;
                return myValue;
            }
            else
            {
                return "";
            }
        }

        public void UnprotectSheet()
        {
            ws.Unprotect();
        }

        //public List<ArmorModel> getArmorModels(int sheet)
        //{
        //    List<ArmorModel> myList = new List<ArmorModel>();

        //    int rowStart = 2;
        //    int rowEnd = 14;
        //    int columnStart = 1;
        //    int columnEnd = 3;
        //    Range range = (Range)ws.Range[ws.Cells[rowStart, rowEnd], ws.Cells[columnStart, columnEnd]];
        //    object[,] holder = range.Value2;
        //    string[,] returnstring = new string[rowEnd - rowStart, columnEnd - columnStart];

        //    for (int i = 1; i <= rowEnd - rowStart; i++)
        //    {
        //        returnstring[]
        //    }

        //    int row = 1;
        //    int column = 1;

        //    int i = 0;
        //    while(i == 0)
        //    {

        //    }

        //}

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
                column = 0;
                j = 0;

                if ((column == 0) || ws.Cells[row, column].value2 != null)
                {
                    var currentRow = new List<string>();

                    while (j == 0) //iterates through all the columns
                    {
                        column++;

                        if (ws.Cells[row, column].value2 != null)
                        {
                            string cellValue = ws.Cells[row, column].Value2;
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
    }
}
