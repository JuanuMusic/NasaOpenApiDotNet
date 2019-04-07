using System;
using System.Collections.Generic;
using System.Text;

namespace NasaOpenApis.EPIC.Models
{
    /// <summary>
    /// An enum that represents the available archive types.
    /// </summary>
    public enum Archive
    {
        /// <summary>
        /// Natural images
        /// </summary>
        Natural,
        
        /// <summary>
        /// Enhanced images
        /// </summary>
        Enhanced
    }

    /// <summary>
    /// Extension methods for <see cref="Archive"/> enum.
    /// </summary>
    public static class ArchiveExtensions
    {
        /// <summary>
        /// Returns the string representation of an <see cref="Archive"/>
        /// </summary>
        /// <param name="pImagepArchiveype"></param>
        /// <returns></returns>
        public static string GetString(this Archive pImagepArchiveype)
        {
            switch (pImagepArchiveype)
            {
                case Archive.Natural:
                    return "natural";
                case Archive.Enhanced:
                    return "enhanced";
                default:
                    return "natural";
            }
        }
    }
}
