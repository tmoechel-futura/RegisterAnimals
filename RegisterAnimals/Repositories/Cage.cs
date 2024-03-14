using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{
    internal class Cage<T> : ICage<T> where T : Animal
    {
        List<Animal> animals = new List<Animal>();

        public void AddAnimal(T animal)
        {
            animals.Add(animal);
        }

        public T GetFirstAnimalInCage() 
        {
            return (T)animals.First();
        }
    }
}
