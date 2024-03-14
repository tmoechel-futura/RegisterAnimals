using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{
    
    public interface ICage<T> where T : Animal
    {
        public void AddAnimal(T animal);
        T GetFirstAnimalInCage();

    }
}
