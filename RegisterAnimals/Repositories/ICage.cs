using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{
    
    public interface IPushCage<in T> where T : Animal
    {
        public void AddAnimal(T animal); // NOT OK T must be contravarian
    }

    public interface IReadCage<out T> where T : Animal
    {
        T GetFirstAnimalInCage();
    }


    public interface ICage<T> : IPushCage<T>, IReadCage<T> where T : Animal
    {
        public void AddAnimal(T animal); // NOT OK T must be contravarian
        T GetFirstAnimalInCage();

    }

    //public interface ICage<T> : IPushCage<T>, IReadCage<T> where T : Animal
    //{
    //}

}
