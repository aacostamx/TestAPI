﻿using System;
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
            StartDate = new DateTime();
            EndDate = new DateTime();
            itineraries = new List<ItineraryFile>();
            readServerFile = false;
            email = true;
            errors = new List<string>();
            sucess = false;
            inputDates = true;
        }

        /// <summary>
        /// Start Date
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End Date
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the itineraries.
        /// </summary>
        /// <value>
        /// The itineraries.
        /// </value>
        public List<ItineraryFile> itineraries { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [read server file].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [read server file]; otherwise, <c>false</c>.
        /// </value>
        public bool readServerFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [send mail].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [send mail]; otherwise, <c>false</c>.
        /// </value>
        public bool email { get; set; }

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        public List<string> errors { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ItineraryUploadAPI"/> is sucess.
        /// </summary>
        /// <value>
        ///   <c>true</c> if sucess; otherwise, <c>false</c>.
        /// </value>
        public bool sucess { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [input dates].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [input dates]; otherwise, <c>false</c>.
        /// </value>
        public bool inputDates { get; set; }
    }
}
