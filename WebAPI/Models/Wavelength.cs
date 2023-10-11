/*
 * Copyright (c) 2023, UFMG, Inc. All rights reserved.
 */

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebAPI.Models;

    /// <summary>
    /// The User entity.
    /// </summary>
    public class Wavelength : IdentifiableEntity
    {
        /// <summary>
        /// Gets or sets the user handle.
        /// </summary>
        /// <value>
        /// The user handle.
        /// </value>
        [Required]
        public string nmWavele1ength { get; set; }
        public string Color { get; set; }
        public ICollection<SensorData> SensorData { get; } // Collection navigation containing dependents
    }

