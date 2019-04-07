using System;
using System.Collections.Generic;
using System.Text;

namespace NasaOpenApis.EPIC.Models
{
    /// <summary>
    /// Represents a Query object to query the EPIC API.
    /// </summary>
    public class EpicQuery
    {
        #region Constructors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pImageType">The type of images to query.</param>
        public EpicQuery(Archive pImageType)
        {
            // Set the image type.
            Archive = pImageType;
        } 
        #endregion

        #region Public Properties
        /// <summary>
        /// Indicates the archive type from where to query.
        /// </summary>
        public Archive Archive { get; set; }

        /// <summary>
        /// The date from which to Query for epic metadata.
        /// Leave NULL to retrieve all.
        /// </summary>
        public DateTime? Date { get; set; }
        #endregion

        #region Method Overrides

        /// <summary>
        /// Converts this <see cref="EpicQuery"/> into a string representation that is used to make the request to the API.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            // Get the image type string representation.
            string retval = this.Archive.GetString();

            // Set the Date
            if (Date.HasValue)
                retval += $"/date/{Date.Value.ToString("yyyy-MM-dd")}";

            // Return the generated string representation.
            return retval;
        } 
        #endregion
    }
}
