﻿using ApiData.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiData.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        
    }

  
}
