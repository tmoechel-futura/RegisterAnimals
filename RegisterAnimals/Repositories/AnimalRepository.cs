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
        List<T> animals = new List<T>();

        public void AddAnimal(T animal)
        {
            animals.Add(animal);
        }

        public int GetLionCount() { 
            return animals.Where( animal => animal is Lion).Count(); 
        }

        public int GetElephantCount()
        {
            return animals.Where(animal => animal is Elephant).Count();
        }
    }
}
