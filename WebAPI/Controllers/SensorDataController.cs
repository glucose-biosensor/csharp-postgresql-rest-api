/*
 * Copyright (c) 2023, UFMG, Inc. All rights reserved.
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Common;
using WebAPI.Models;
using WebAPI.Services;
using WebAPI.Exceptions;

namespace WebAPI.Controllers
{
    public class SensorDataController : BaseController
    {

        /// <summary>
        /// The sensor data repository.
        /// </summary>
        private readonly ISensorDataService _repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SensorDataController"/> class.
        /// </summary>
        /// <param name="repository">The SensorData repository.</param>
        public SensorDataController(ISensorDataService repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Gets all SensorData items.
        /// </summary>
        /// <returns>All SensorData items.</returns>
        [HttpGet("")]
        public IList<SensorData> GetAll()
        {
            return _repository.GetAll();
        }


        /// <summary>
        /// Gets all SensorData items given user Id.
        /// </summary>
        /// <returns>User's SensorData.</returns>
        [HttpGet("{id}")]
        public IList<SensorData> GetUserData(int id)
        {
            return _repository.GetSensorDataByUserId(id);
        }

        /// <summary>
        /// Creates the specified SensorData item.
        /// </summary>
        /// <param name="model">The SensorData model.</param>
        /// <returns>The Id of created item.</returns>
        [HttpPost("")]
        public int Create(SensorData model)
        {
            ValidateModel(model);
            return _repository.Create(model).Id;
        }
        
        /// <summary>
        /// Deletes SensorData with the given user Id.
        /// </summary>
        /// <param name="id">The Id of the User to delete sensor data.</param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        /// <summary>
        /// Validates the model.
        /// </summary>
        /// <param name="model">The model.</param>
        private static void ValidateModel(SensorData model)
        {
            Util.ValidateArgumentNotNull(model, nameof(model));
        }

    }
}