using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6Nikolay.Model
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        // М -> 1
        public int Age { get; set; }
        public int BreedId { get; set; } //FK
        public Breed Breeds { get; set; }
    }
}
