using Microsoft.VisualStudio.TestTools.UnitTesting;
using NasaOpenApis.EPIC;
using NasaOpenApis.EPIC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NasaOpenApis.Tests.EPIC
{
    [TestClass]
    public class EPICTests
    {
        [TestMethod]
        public async Task EPIC_QueryAllNatural_CountGreaterThanZero()
        {
            // ARRANGE
            EPICApi api = new EPICApi();
            EpicQuery query = new EpicQuery(Archive.Natural);

            // ACT 
            EpicMetadata[] retVal = await api.QueryArrayAsync(query);

            // ASSERT
            Assert.AreNotEqual(0, retVal.Length);
        }

        [TestMethod]
        public async Task EPIC_QueryAllEnhanced_CountGreaterThanZero()
        {
            // ARRANGE
            EPICApi api = new EPICApi();
            EpicQuery query = new EpicQuery(Archive.Enhanced);

            // ACT 
            EpicMetadata[] retVal = await api.QueryArrayAsync(query);

            // ASSERT
            Assert.AreNotEqual(0, retVal.Length);
        }

        [TestMethod]
        public async Task EPIC_QueryByDateNatural_CountGreaterThanZero()
        {
            // ARRANGE
            EPICApi api = new EPICApi();
            EpicQuery query = new EpicQuery(Archive.Natural);
            query.Date = new System.DateTime(2019, 04, 04);

            // ACT 
            EpicMetadata[] retVal = await api.QueryArrayAsync(query);

            // ASSERT
            Assert.AreNotEqual(0, retVal.Length);
        }

        [TestMethod]
        public async Task EPIC_QueryByDateEnhanced_CountGreaterThanZero()
        {
            // ARRANGE
            EPICApi api = new EPICApi();
            EpicQuery query = new EpicQuery(Archive.Enhanced);
            query.Date = new System.DateTime(2019, 04, 04);

            // ACT 
            EpicMetadata[] retVal = await api.QueryArrayAsync(query);

            // ASSERT
            Assert.AreNotEqual(0, retVal.Length);
        }
    }
}
