using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Coroian_Daniel_Lab8.Models;

namespace Coroian_Daniel_Lab8.Data
{
    public class Coroian_Daniel_Lab8Context : DbContext
    {
        public Coroian_Daniel_Lab8Context (DbContextOptions<Coroian_Daniel_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Coroian_Daniel_Lab8.Models.Book> Book { get; set; }

        public DbSet<Coroian_Daniel_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Coroian_Daniel_Lab8.Models.Category> Category { get; set; }
    }
}
