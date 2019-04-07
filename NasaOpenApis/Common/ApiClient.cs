using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NasaOpenApis
{
    public class ApiClient
    {
        /// <summary>
        /// Stores the actual API Key.
        /// </summary>
        string _apiKey = String.Empty;

        /// <summary>
        /// Stores the api Base URL.
        /// </summary>
        string _apiBaseUrl = String.Empty;

        /// <summary>
        /// Executes a GET request and deserializes the result into the <typeparamref name="TResult"/> type.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="pEndPoint"></param>
        /// <returns></returns>
        public async Task<TResult> Get<TResult>(Uri pEndPoint)
        {
            string jsonResponse = String.Empty;

            // Request and get the response.
            jsonResponse = await Get(pEndPoint);

            // Deserialize the response 
            TResult retVal = Newtonsoft.Json.JsonConvert.DeserializeObject<TResult>(jsonResponse);

            return retVal;
        }

        /// <summary>
        /// Executes a GET request and returns the string response.
        /// </summary>
        /// <param name="pEndPoint"></param>
        /// <returns></returns>
        public async Task<string> Get(Uri pEndPoint)
        {
            // Instantiate the client
            var client = new HttpClient();

            // Request and get the response.
            string retVal = await client.GetStringAsync(pEndPoint);

            // Dispose the client
            client.Dispose();

            return retVal;
        }

    }
}
