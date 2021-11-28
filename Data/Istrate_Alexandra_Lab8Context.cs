using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Istrate_Alexandra_Lab8.Models;

namespace Istrate_Alexandra_Lab8.Data
{
    public class Istrate_Alexandra_Lab8Context : DbContext
    {
        public Istrate_Alexandra_Lab8Context (DbContextOptions<Istrate_Alexandra_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Istrate_Alexandra_Lab8.Models.Book> Book { get; set; }

        public DbSet<Istrate_Alexandra_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
