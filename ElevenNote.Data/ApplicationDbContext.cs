using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElevenNote.Data.Entities;  // Proivdes us connectivity to the UserEntity.
using Microsoft.EntityFrameworkCore; // Gives us access to the DbContext class that is being inherited

namespace ElevenNote.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}