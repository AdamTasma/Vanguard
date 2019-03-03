﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataImporterTests.Integration
{
    [TestClass]
    class ImportDataFromExcelFileTests
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
