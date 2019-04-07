using System;
using System.Collections.Generic;
using System.Text;

namespace NasaOpenApis.EPIC.Models
{
    /// <summary>
    /// An enum that represents an image type to request.
    /// </summary>
    public enum ImageType
    {
        PNG,
        JPG,
        Thumbnail
    }

    /// <summary>
    /// Extension methos for <see cref="ImageType"/> enum.
    /// </summary>
    public static class ImageTypeExtensions
    {
        /// <summary>
        /// Return the string that represents the image type on the Epic API.
        /// </summary>
        /// <param name="pImageType"></param>
        /// <returns></returns>
        public static string GetString(this ImageType pImageType)
        {
            switch (pImageType)
            {
                case ImageType.PNG:
                    return "png";
                case ImageType.JPG:
                    return "jpg";
                case ImageType.Thumbnail:
                    return "thumbs";
                default:
                    return "jpg";
            }
        }
    }
}
