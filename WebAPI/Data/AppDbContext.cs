/*
 * Copyright (c) 2019, TopCoder, Inc. All rights reserved.
 */
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data;

    /// <summary>
    /// The application DB context.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public DbSet<User> Users { get; set; }
        public DbSet<SensorData> SensorData { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppDbContext"/> class.
        /// </summary>
        /// <param name="contextOptions">The context options.</param>
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions)
            : base(contextOptions)
        {
        }

        /// <summary>
        /// Customizes mappings between entity model and database.
        /// </summary>
        /// <param name="builder">The model builder.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>( user => {
                user.HasKey(e => e.Id);
                user.HasIndex(e => e.Username).IsUnique();
                user.Property(e => e.Password).HasMaxLength(20);
                user.HasMany(e => e.SensorData).WithOne(e => e.User).HasForeignKey(e => e.IdUser).IsRequired();
            });

            builder.Entity<Wavelength>( wavelength => 
            {
                wavelength.HasKey(e => e.Id);
                wavelength.Property(e => e.Color);
                wavelength.Property(e => e.nmWavele1ength);
                wavelength.HasMany(e => e.SensorData).WithOne(e => e.Wavelength).HasForeignKey(e => e.IdWavelength).IsRequired();
            });

            builder.Entity<SensorData>( data => 
            {
                data.HasKey(e => e.Id);
                data.Property(e => e.Timestamp);
                data.Property(e => e.Data);
                data.HasOne(e => e.User).WithMany(e => e.SensorData).HasForeignKey(e => e.IdUser).IsRequired();
                data.HasOne(e => e.Wavelength).WithMany(e => e.SensorData).HasForeignKey(e => e.IdWavelength).IsRequired();
            });


            base.OnModelCreating(builder);
        }
    }

