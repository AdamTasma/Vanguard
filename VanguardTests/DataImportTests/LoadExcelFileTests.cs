using NUnit.Framework;
using Vanguard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanguardTests.DataImportTests
{
    [TestFixture]
    class LoadExcelFileTests
    {
        [Test]
        public void LoadDbVersion_LoadsCorrectly_WithValidData()
        {
            var sut = new LoadExcelFile();

            var result = sut.LoadDbVersion();

            //sut.Close();
            Assert.AreEqual("1.1.2", result);
        }
    }
}
