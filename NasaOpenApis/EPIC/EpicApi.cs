/* REFERENCE LINKS:
 * https://api.nasa.gov/api.html#EPIC
 * https://epic.gsfc.nasa.gov/about/api
 */

using NasaOpenApis.EPIC.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NasaOpenApis.EPIC
{
    public class EPICApi
    {
        #region Private Fields
        /// <summary>
        /// Stores the <see cref="ApiClient"/> instance used to make requests to the API.
        /// </summary>
        ApiClient _client = null;

        /// <summary>
        /// Stores the actual API Key.
        /// </summary>
        string _apiKey = "DEMO_KEY";

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the Base Url of the API.
        /// The default value is "https://epic.gsfc.nasa.gov/api/"
        /// </summary>
        public Uri BaseUrl { get; set; } = new Uri("https://epic.gsfc.nasa.gov/");
        
        #endregion

        /// <summary>
        /// Instantiates the EPIC Api with the default api key.
        /// </summary>
        public EPICApi()
        {
            // Instantiate the Api Client
            _client = new ApiClient();
        }

        /// <summary>
        /// Instantiates the EPIC Api with a custom api key.
        /// </summary>
        /// <param name="pApiKey"></param>
        public EPICApi(string pApiKey)
        {
            // Instantiate the Api Client
            _client = new ApiClient();

            // Set the new api key
            _apiKey = pApiKey;
        }


        /// <summary>
        /// Executes the given query against the EPIC APi.
        /// </summary>
        /// <param name="pQuery"></param>
        /// <returns></returns>
        public async Task<EpicMetadata[]> QueryArrayAsync(EpicQuery pQuery)
        {
            // Generate the URI with the API KEY
            Uri requestUrl = new Uri(BaseUrl, $"api/{pQuery.ToString()}?api_key={_apiKey}");

            // Make the request to the api and get the result.
            var result = await _client.Get<EpicMetadata[]>(requestUrl);

            // Set th 
            // Return the result.
            return result;
        }
    }
}
