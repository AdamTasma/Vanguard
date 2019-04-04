using Vanguard;
using Vanguard.Models;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace VanguardTests
{
    [TestFixture]
    public class DataImportTests
    {
        public string filePath = "C:\\Users\adamt\\source\repos\\Vanguard\\ExcelFileFolder\\VanguardDB.xlsx";

        [Test]
        public void StupidTest()
        {
            Assert.True(true);
        }

        [Test]
        public void TestTestTest()
        {
            var sut = new LoadExcelFile();
            var result = sut.TestTest();

            Assert.Equals(2, result);
        }

        [Test]
        public void GetTestModelsImportsCorrectly()
        {
            var sut = new LoadExcelFile();

            var result = sut.LoadTestModelFromDB(filePath);

            Assert.IsNotEmpty(result);
        }


    }
}
