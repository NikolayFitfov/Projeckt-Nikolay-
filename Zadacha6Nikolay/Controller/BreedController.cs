using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadacha6Nikolay.Model;

namespace Zadacha6Nikolay.Controller
{
    public class BreedController
    {
        private PriutAnimalDbContext _animalDbContext = new PriutAnimalDbContext();
        public List<Breed> GetBreeds()
        {
             return _animalDbContext.Breeds.ToList();
        }
        public string GetBreedById(int id)
        {
            return _animalDbContext.Breeds.Find(id).Name;
        }
    }
}
