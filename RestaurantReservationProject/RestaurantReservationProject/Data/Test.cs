using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Presentation.models;

    public class Test : DbContext
    {
        public Test (DbContextOptions<Test> options)
            : base(options)
        {
        }

        public DbSet<Presentation.models.RestaurantModel> RestaurantModel { get; set; }
    }
