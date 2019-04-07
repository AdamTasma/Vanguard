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
            Excel sut = new Excel(8);

            var result = sut.ReadCell(1, 0);

            sut.Close();

            Assert.AreEqual("stringer", result);
        }

        [Test]
        public void LoadsAllRowsTest()
        {
            Excel sut = new Excel(7);

            var result = sut.GetRows();

            sut.Close();

            Assert.AreEqual("plot", result[2][1]);
        }

        [Test]
        public void UnprotectSheet()
        {
            Excel sut = new Excel(7);

            sut.UnprotectSheet();

            sut.Close();
        }
    }
}
