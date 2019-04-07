using NasaOpenApis.Common;
using System;

namespace NasaOpenApis.EPIC.Models
{
    /// <summary>
    /// Represents the metadata received by the <see cref="EPICApi"/>.
    /// </summary>
    public class EpicMetadata
    {
        /// <summary>
        /// Identifier for the image.
        /// </summary>
        public string identifier { get; set; }

        /// <summary>
        /// Caption of the image.
        /// </summary>
        public string caption { get; set; }

        /// <summary>
        /// The name of the image without the extension format.
        /// </summary>
        public string image { get; set; }

        public string version { get; set; }

        /// <summary>
        /// Geographical coordinates that the satellite is looking at
        /// </summary>
        public Coordinates centroid_coordinates { get; set; }
        
        /// <summary>
        /// Position of the satellite in space
        /// </summary>
        public Vector3 dscovr_j2000_position { get; set; }

        /// <summary>
        /// Position of the moon in space
        /// </summary>
        public Vector3 lunar_j2000_position { get; set; }

        /// <summary>
        /// Position of the sun in space
        /// </summary>
        public Vector3 sun_j2000_position { get; set; }

        /// <summary>
        /// Satellite attitude
        /// </summary>
        public Quaternion attitude_quaternions { get; set; }

        /// <summary>
        /// The date this data was received.
        /// </summary>
        public DateTime date { get; set; }

        /// <summary>
        /// Returns the corresponding Image URL for the current metadata and the given <see cref="ImageType"/>.
        /// </summary>
        /// <param name="pImageType"></param>
        /// <returns></returns>
        public Uri GetImageUrl(EPICApi pApi, EpicQuery pGeneratingQUery, ImageType pImageType)
        {
            // Get the image format
            string imageFormat = pImageType == ImageType.Thumbnail ? "jpg" : pImageType.GetString();
            // Generate the filename
            string filename = $"{image}.{imageFormat}";

            // Generate the URL
            string retVal = $"archive/{pGeneratingQUery.Archive.GetString()}/{date.Year}/{date.Month.ToString("00")}/{date.Day.ToString("00")}/{pImageType.GetString()}/{filename}";

            // Return the value.
            return new Uri(pApi.BaseUrl, retVal);
        }

    }

}
