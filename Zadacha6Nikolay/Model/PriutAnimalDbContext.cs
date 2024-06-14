using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6Nikolay.Model
{
    public class PriutAnimalDbContext:DbContext
    {
        public PriutAnimalDbContext() : base("PriutAnimalDbContext")
        {

        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Breed> Breeds { get; set; }
    }
}
