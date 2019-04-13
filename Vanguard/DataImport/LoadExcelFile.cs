using Vanguard.Models;
using Vanguard.DataImport;

namespace Vanguard
{
    public class LoadExcelFile
    {
        public DataBase LoadAllTabs()
        {
            DataBase dataBase = new DataBase
            {
                DbVersion = LoadDbVersion()
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

    }
}
