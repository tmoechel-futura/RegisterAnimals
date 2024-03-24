using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{
    internal interface IAnimalRepository<T> where T: Animal
    {
        public IEnumerable<Animal> GetAllAnimals();
        public void AddAnimal(T animal);

        public int GetLionCount();

        public int GetElephantCount();
    }
}
