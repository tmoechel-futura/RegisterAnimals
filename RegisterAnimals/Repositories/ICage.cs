using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{
    
    public interface IPushAnimal<in T> where T: Animal
    {
        public void AddAnimal(T animal); 
    }

    public interface IListAnimal<out T> where T : Animal
    {
        T GetFirstAnimalInCage();
    }

    public interface ICage<T> : IListAnimal<T>, IPushAnimal<T> where T : Animal
    {       
    }
}
