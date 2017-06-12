using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SimpleDemo.Models
{
    public class MVCMovieContext : DbContext
    {
        public MVCMovieContext(DbContextOptions<MVCMovieContext> options)
            : base(options)
        {
        }

        public DbSet<SimpleDemo.Models.Movie> Movie { get; set; }
    }
}
