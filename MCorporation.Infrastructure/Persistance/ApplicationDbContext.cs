﻿using MCorporation.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace MCorporation.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }
        public DbSet<User> Users { get; set; }
    }
}
