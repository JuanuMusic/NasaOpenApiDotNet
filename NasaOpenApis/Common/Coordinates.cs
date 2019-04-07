using System;
using System.Collections.Generic;
using System.Text;

namespace NasaOpenApis.EPIC.Models
{
    /// <summary>
    /// Represents latitude and longitude coordinates
    /// </summary>
    public class Coordinates
    {
        /// <summary>
        /// Latitude value
        /// </summary>
        public float lat { get; set; }

        /// <summary>
        /// Longitude value
        /// </summary>
        public float lon { get; set; }
    }
}
