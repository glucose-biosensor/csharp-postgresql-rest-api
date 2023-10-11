/*
 * Copyright (c) 2019, TopCoder, Inc. All rights reserved.
 */
using System.Collections.Generic;
using System.Linq;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Services.Impl
{
    /// <summary>
    /// The user repository.
    /// </summary>
    public class UserService: IUserService
    {
        /// <summary>
        /// The database context.
        /// </summary>
        private AppDbContext _db;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="context">The DB context.</param>
        public UserService(AppDbContext context)
        {
            _db = context;
        }

        /// <summary>
        /// Gets the User by handle.
        /// </summary>
        /// <param name="handle">The user handle.</param>
        /// <returns>Found user or null.</returns>
        public User GetUserByUsername(string username)
        {
            return _db.Users.FirstOrDefault(x => x.Username == username);
        }

        /// <summary>
        /// Gets the User by Id.
        /// </summary>
        /// <param name="id">The user Id.</param>
        /// <returns>Found user or null.</returns>
        public User GetUserById(int id)
        {
            return _db.Users.Find(id);
        }

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns>All users.</returns>
        public IList<User> GetAll()
        {
            return _db.Users.ToList();
        }

        /// <summary>
        /// Creates the given user.
        /// </summary>
        /// <param name="entity">The user entity.</param>
        /// <returns>Created user entity.</returns>
        public User Create(User entity)
        {
            var newEntity = _db.Users.Add(entity).Entity;
            _db.SaveChanges();
            return newEntity;
        }

        /// <summary>
        /// Updates given user.
        /// </summary>
        /// <param name="entity">The user entity.</param>
        public void Update(User entity)
        {
            var existing = GetUserById(entity.Id);
            existing.Username = entity.Username;
            _db.SaveChanges();
        }

        /// <summary>
        /// Deletes user with given Id.
        /// </summary>
        /// <param name="id">The user Id.</param>
        public void Delete(int id)
        {
            var existing = GetUserById(id);
            _db.Remove(existing);
            _db.SaveChanges();
        }
    }
}
