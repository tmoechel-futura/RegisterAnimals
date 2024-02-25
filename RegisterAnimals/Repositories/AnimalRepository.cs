using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{
    internal class AnimalRepository<T> where T : Animal
    {
        List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public int GetLionCount() { 
            return animals.Where( animal => animal is Lion).Count(); 
        }

        public int GetElefantCount()
        {
            return animals.Where(animal => animal is Elefant).Count();
        }

    }
}
