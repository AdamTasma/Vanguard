using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLoadLibrary;

namespace DataLoadUnitTest_DebugProject
{
    [TestClass]
    public class OpenExcelSheet
    {
        [TestMethod]
        public void OpenExcelSheetForDebug()
        {
            var dataLoadLibrary = new DataLoadLibrary.LoadExcelFile();

            var excelFileData = dataLoadLibrary.GetTraits("C:\\Users\\adamt\\source\\repos\\Vanguard\\ExcelFileFolder\\VanguardDB.xlsx");

            var breakpoint = "here";
        }
    }
}