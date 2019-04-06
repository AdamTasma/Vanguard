using Vanguard.DataImport;
using NUnit.Framework;

namespace VanguardTests
{
    [TestFixture]
    public class DataImportTests
    {
        //public string filePath = "D:\\repos\\Vanguard\\ExcelFileFolder\\VanguardDB.xlsx";

        [Test]
        public void LoadExcelDbTest()
        {
            Excel excel = new Excel(8);

            var result = excel.ReadCell(1, 0);

            excel.Close();

            Assert.AreEqual("stringer", result);
        }
    }
}
