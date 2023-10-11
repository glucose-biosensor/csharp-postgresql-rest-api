/*
 * Copyright (c) 2023 UFMG. All rights reserved.
 */

using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models;

    /// <summary>
    /// The SensorData entity.
    /// </summary>
    public class SensorData : IdentifiableEntity
    {
        /// <summary>
        /// Gets or sets the user ID, wavelength, timestamp and sensor data.
        /// </summary>
        [Required]
        public int IdUser { get; set; }
        public int IdWavelength { get; set; }
        public int Timestamp { get; set; }
        public float Data { get; set; }

        public User User { get; set; }
        public Wavelength Wavelength { get; set; }
    }

