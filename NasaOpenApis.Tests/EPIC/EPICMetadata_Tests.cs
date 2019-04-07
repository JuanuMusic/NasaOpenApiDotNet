using Microsoft.VisualStudio.TestTools.UnitTesting;
using NasaOpenApis.EPIC;
using NasaOpenApis.EPIC.Models;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NasaOpenApis.Tests.EPIC
{
    [TestClass]
    public class EPICMetadata_Tests
    {
        [TestMethod]
        public async Task EpicMetadata_GetImageUrlPng_IsValidUrl()
        {
            // ARRANGE
            EPICApi api = new EPICApi();
            EpicQuery query = new EpicQuery(Archive.Natural);
            query.Date = new DateTime(2019, 04, 04);

            // ACT
            var result = await api.QueryArrayAsync(query);

            #region Assert
            // Get the first element
            EpicMetadata firstElement = result.First();
            // Get the image url
            Uri imageUrl = firstElement.GetImageUrl(api, query, ImageType.PNG);

            // Check if the URL exists.
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(imageUrl);
            Assert.IsTrue(response.IsSuccessStatusCode);
            #endregion
        }

        [TestMethod]
        public async Task EpicMetadata_GetImageUrlJpg_IsValidUrl()
        {
            // ARRANGE
            EPICApi api = new EPICApi();
            EpicQuery query = new EpicQuery(Archive.Natural);
            query.Date = new DateTime(2019, 04, 04);

            // ACT
            var result = await api.QueryArrayAsync(query);

            #region Assert
            // Get the first element
            EpicMetadata firstElement = result.First();
            // Get the image url
            Uri imageUrl = firstElement.GetImageUrl(api, query, ImageType.JPG);

            // Check if the URL exists.
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(imageUrl);
            Assert.IsTrue(response.IsSuccessStatusCode);
            #endregion
        }

        [TestMethod]
        public async Task EpicMetadata_GetImageUrlThumbs_IsValidUrl()
        {
            // ARRANGE
            EPICApi api = new EPICApi();
            EpicQuery query = new EpicQuery(Archive.Natural);
            query.Date = new DateTime(2019, 04, 04);

            // ACT
            var result = await api.QueryArrayAsync(query);

            #region Assert
            // Get the first element
            EpicMetadata firstElement = result.First();
            // Get the image url
            Uri imageUrl = firstElement.GetImageUrl(api, query, ImageType.Thumbnail);

            // Check if the URL exists.
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(imageUrl);
            Assert.IsTrue(response.IsSuccessStatusCode);
            #endregion
        }
    }
}
