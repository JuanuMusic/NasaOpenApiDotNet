using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NasaOpenApis.Tests
{
    [TestClass]
    public class BaseApiTests
    {
        [TestMethod]
        public async Task BaseApi_GetRequest_IsNotNullOrWhiteSpace()
        {
            // ARRANGE
            ApiClient api = new ApiClient();
            Uri requestUri = new Uri("https://epic.gsfc.nasa.gov/api/natural");

            // ACT
            string result = await api.Get(requestUri);

            // ASSERT
            Assert.IsFalse(string.IsNullOrWhiteSpace(result));
        }
    }
}
