using System;
using System.Collections.Generic;

namespace TestAPI.Models
{

    public class ItineraryUploadVO
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItineraryUploadVO"/> class.
        /// </summary>
        public ItineraryUploadVO()
        {
            lines = new List<string>();
            StartDate = new DateTime();
            EndDate = new DateTime();
            AirlineCodeCombobox = string.Empty;
            readFile = false;
            email = false;
        }

        /// <summary>
        /// Gets or sets the lines.
        /// </summary>
        /// <value>
        /// The lines.
        /// </value>
        public List<string> lines { get; set; }

        /// <summary>
        /// Start Date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End Date
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// AirlineCodeCombobox
        /// </summary>
        public string AirlineCodeCombobox { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [read file from server].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [read file from server]; otherwise, <c>false</c>.
        /// </value>
        public bool readFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send mail].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [send mail]; otherwise, <c>false</c>.
        /// </value>
        public bool email { get; set; }
    }
}
