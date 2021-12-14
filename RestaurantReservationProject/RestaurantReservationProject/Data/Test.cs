using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Presentation.models;
using Presentation.Models;

    public class Test : DbContext
    {
        public Test (DbContextOptions<Test> options)
            : base(options)
        {
        }

        public DbSet<RestaurantViewModel> RestaurantModel { get; set; }

        public DbSet<CommentViewModel> CommentModel { get; set; }
    }
