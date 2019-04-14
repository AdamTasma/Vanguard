using NUnit.Framework;
using Vanguard;

namespace VanguardTests.DataImportTests
{
    [TestFixture]
    class LoadExcelFileTests
    {
        [Test]
        public void LoadDbVersion_LoadsCorrectly()
        {
            var sut = new LoadExcelFile();

            var result = sut.LoadDbVersion(null, sut.versionTab);

            Assert.NotNull(result.Item1);
            Assert.True(result.Item1.Contains("."));

            Assert.IsNull(result.Item2);
        }

        [Test]
        public void LoadWeaponsDb_LoadsCorrectly()
        {
            var sut = new LoadExcelFile();

            var result = sut.LoadWeaponsDb(null, sut.weaponsTab);

            Assert.True(result.Item1.Count > 0);
            Assert.NotNull(result.Item1[0].Name);

            Assert.IsNull(result.Item2);
        }

        [Test]
        public void LoadArmorDb_LoadsCorrectly()
        {
            var sut = new LoadExcelFile();

            var result = sut.LoadArmorDb(null, sut.armorTab);

            Assert.True(result.Item1.Count > 0);
            Assert.NotNull(result.Item1[0]);

            Assert.IsNull(result.Item2);
        }
    }
}
