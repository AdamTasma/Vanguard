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
        public string filePath = "D:\\repos\\Vanguard\\ExcelFileFolder\\VanguardDB.xlsx";

        [Test]
        public void GetTestModelsImportsCorrectly()
        {
            var sut = new LoadExcelFile();

            var result = sut.LoadTestModelFromDB(filePath);

            Assert.IsNotEmpty(result);
        }


    }
}
