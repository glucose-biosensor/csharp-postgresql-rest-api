/*
 * Copyright (c) 2023, UFMG. All rights reserved.
 */
using System.Collections.Generic;
using System.Linq;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Services.Impl
{
    /// <summary>
    /// The sensor data repository.
    /// </summary>
    public class SensorDataService : ISensorDataService
    {
        /// <summary>
        /// The database context.
        /// </summary>
        private AppDbContext _db;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="context">The DB context.</param>
        public SensorDataService(AppDbContext context)
        {
            _db = context;
        }

         /// <summary>
        /// Gets the sensor data given user id.
        /// </summary>
        /// <param name="idUser">The user id.</param>
        /// <returns>Found sensor data or null.</returns>
        public IList<SensorData> GetSensorDataByUserId(int idUser)
        {
            return _db.SensorData.ToList().FindAll(x => x.IdUser == idUser);
        }

        /// <summary>
        /// Gets the sensor data given user id and wavelength id.
        /// </summary>
        /// <param name="idUser">The user id.</param>
        /// <param name="idWavelength">The wavelength id (green = 0, red = 1, infrared = 2).</param>
        /// <returns>Found sensor data or null.</returns>
        public IList<SensorData> GetSensorDataByUserIdAndWavelengthId(int idUser, int idWavelength)
        {
            var existing = GetSensorDataByUserId(idUser);
            if (existing != null)
            {
                return existing.ToList().FindAll(x => x.IdWavelength == idWavelength);
            }
            return null;
        }

        /// <summary>
        /// Gets all sensor data.
        /// </summary>
        /// <returns>All sensor data.</returns>
        public IList<SensorData> GetAll()
        {
            return _db.SensorData.ToList();
        }

        /// <summary>
        /// Creates the given sensor data.
        /// </summary>
        /// <param name="entity">The sensor data entity.</param>
        /// <returns>Created SensorData entity.</returns>
        public SensorData Create(SensorData entity)
        {
            var newEntity = _db.SensorData.Add(entity).Entity;
            _db.SaveChanges();
            return newEntity;
        }


        /// <summary>
        /// Deletes sensor data given user id.
        /// </summary>
        /// <param name="id">The user Id.</param>
        public void Delete(int idUser)
        {
            var existing = GetSensorDataByUserId(idUser);
            foreach(SensorData d in existing)
            {
                _db.Remove(d);
            }
            _db.SaveChanges();
        }
    }
}
