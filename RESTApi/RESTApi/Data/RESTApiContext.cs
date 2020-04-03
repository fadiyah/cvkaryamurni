using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RESTApi.Models
{
    public class RESTApiContext : DbContext
    {
        public RESTApiContext (DbContextOptions<RESTApiContext> options)
            : base(options)
        {
        }

        public DbSet<RESTApi.Models.Movie> Movie { get; set; }
    }
}
