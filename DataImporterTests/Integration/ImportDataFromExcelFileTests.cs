using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataImporterTests.Integration
{
    [TestClass]
    public class ImportDataFromExcelFileTests
    {
        private string excelPath = "C:\\Users\\adamt\\source\\repos\\Vanguard\\ExcelFileFolder\\VanguardDB.xlsx";

        [TestMethod]
        public void LoadAllTabs_LoadsSuccessfully_WithGoodData()
        {
            //var dataLoadLibrary = new DataLoadLibrary.LoadExcelFile();
            var sut = new DataImporter.ImportDataFromExcelFile();

            sut.LoadAllTabs(excelPath);
            //var excelFileData = dataLoadLibrary.GetTraits("C:\\Users\\adamt\\source\\repos\\Vanguard\\ExcelFileFolder\\VanguardDB.xlsx");

            var breakpoint = "here";
        }

        [TestMethod]
        public void GetDbVersionNumberDebug_LoadsSuccessfully_WithGoodData()
        {
            var sut = new DataImporter.ImportDataFromExcelFile();

            var actual = sut.GetDbVersionNumberDebug(excelPath, 4);

            Assert.AreEqual("1.1.1", actual);
        }
    }
}
