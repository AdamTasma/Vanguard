using System;
using System.Collections.Generic;
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

        _Application excel = new _Excel.Application();
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

        public void Close()
        {
            wb.Close();
        }
    }
}
