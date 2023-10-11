/*
 * Copyright (c) 2023, UFMG. All rights reserved.
 */
using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Services
{
    /// <summary>
    /// The sensor data repository interface.
    /// </summary>
    public interface ISensorDataService
    {
        /// <summary>
        /// Creates the given user.
        /// </summary>
        /// <param name="entity">The sensor data entity.</param>
        /// <returns>Created sensor data entity.</returns>
        SensorData Create(SensorData entity);

        /// <summary>
        /// Deletes sensor data given Id.
        /// </summary>
        /// <param name="id">The sensor data Id.</param>
        void Delete(int id);

        /// <summary>
        /// Gets all sensor data.
        /// </summary>
        /// <returns>All sensor data.</returns>
        IList<SensorData> GetAll();

        /// <summary>
        /// Gets the sensor data given user id.
        /// </summary>
        /// <param name="handle">The user id.</param>
        /// <returns>Found user or null.</returns>
        IList<SensorData> GetSensorDataByUserId(int idUser);

        /// <summary>
        /// Gets the sensor data given user id and wavelength id.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="wavelengthId">The wavelength id (green = 0, red = 1, infrared = 2).</param>
        /// <returns>Found user or null.</returns>
        IList<SensorData> GetSensorDataByUserIdAndWavelengthId(int idUser, int idWavelength);
        
    }
}
