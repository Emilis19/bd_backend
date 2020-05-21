using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace scheduleris_backend.Models
{
    public partial class BDbazeContext : DbContext
    {

        public BDbazeContext(DbContextOptions<BDbazeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Place> Place { get; set; }


    }
}
