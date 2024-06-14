using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadacha6Nikolay.Model;

namespace Zadacha6Nikolay.Controller
{
    public class AnimalController
    {
        private PriutAnimalDbContext _animalDbContext = new PriutAnimalDbContext();
        public Animal Get(int id)
        {
            Animal prietikucheta = _animalDbContext.Animals.Find(id);
            if (prietikucheta != null)
            {
                _animalDbContext.Entry(prietikucheta).Reference(x => x.Breeds).Load();
            }
            return prietikucheta;
        }
        public List<Animal> GetAnimals() 
        { 
            return _animalDbContext.Animals.Include("Breed").ToList();
        }
        public void Create(Animal animal)
        {
            _animalDbContext.Animals.Add(animal);
            _animalDbContext.SaveChanges();
        }
        public void Update(Animal animal)
        {
            Animal prietikucheta = _animalDbContext.Animals.Find();
            if (prietikucheta != null)
            {
                return;
            }
            prietikucheta.Age = animal.Age;
            prietikucheta.Name = animal.Name;
            prietikucheta.BreedId = animal.BreedId;
            _animalDbContext.SaveChanges();
        }
        public void Delete(int id) 
        {
            Animal prietikucheta = _animalDbContext.Animals.Find(id);
            _animalDbContext.Animals.Remove(prietikucheta);
            _animalDbContext.SaveChanges();
        }
    }
}
