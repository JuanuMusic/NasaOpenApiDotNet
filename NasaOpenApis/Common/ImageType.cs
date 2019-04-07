using System;
using System.Collections.Generic;
using System.Text;

namespace NasaOpenApis.Common
{
    /// <summary>
    /// Represents an image type to request.
    /// </summary>
    public enum ImageType
    {
        PNG,
        JPG,
        Thumbnail
    }

    public static class ImageTypeExtensions
    {
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
