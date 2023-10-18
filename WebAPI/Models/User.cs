/*
 * Copyright (c) 2019, TopCoder, Inc. All rights reserved.
 */

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebAPI.Models;

    /// <summary>
    /// The User entity.
    /// </summary>
    public class User : IdentifiableEntity
    {
        /// <summary>
        /// Gets or sets the user handle.
        /// </summary>
        /// <value>
        /// The user handle.
        /// </value>
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<SensorData> SensorData { get; } = new List<SensorData>(); // Collection navigation containing dependents
    }

