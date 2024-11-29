using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_first_app.Models;

namespace MVC_first_app.Data
{
    public class MVC_first_appContext : DbContext
    {
        public MVC_first_appContext (DbContextOptions<MVC_first_appContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_first_app.Models.Movie> Movie { get; set; } = default!;
    }
}
