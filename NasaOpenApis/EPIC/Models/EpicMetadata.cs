using NasaOpenApis.Common;
using System;

namespace NasaOpenApis.EPIC.Models
{

    public class EpicMetadata
    {
        public string identifier { get; set; }
        public string caption { get; set; }
        public string image { get; set; }
        public string version { get; set; }
        public CentroidCoordinates centroid_coordinates { get; set; }
        public Vector3 dscovr_j2000_position { get; set; }
        public Vector3 lunar_j2000_position { get; set; }
        public Vector3 sun_j2000_position { get; set; }
        public Quaternion attitude_quaternions { get; set; }
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
