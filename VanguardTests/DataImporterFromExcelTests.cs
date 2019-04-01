using DataImporterFromExcel;
using Vanguard.Models;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace VanguardTests
{
    [TestFixture]
    public class DataImporterFromExcelTests
    {
        public string filePath = "C:\\Users\adamt\\source\repos\\Vanguard\\ExcelFileFolder\\VanguardDB.xlsx";

        [Test]
        public void GetTestModelsImportsCorrectly()
        {
            var sut = new LoadExcelFile();

            var result = sut.LoadTestModelFromDB(filePath);

            Assert.IsNotEmpty(result);
        }
    }
}
