﻿using ddd_sample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ddd_sample.Infrastructure.Contexts
{
    public class ddd_sampleDbContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }

        public ddd_sampleDbContext(DbContextOptions<ddd_sampleDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //conditions
        }
    }
}
