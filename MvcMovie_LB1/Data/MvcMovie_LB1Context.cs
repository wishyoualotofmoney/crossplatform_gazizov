using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie_LB1.Data
{
    public class MvcMovie_LB1Context : DbContext
    {
        public MvcMovie_LB1Context (DbContextOptions<MvcMovie_LB1Context> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
