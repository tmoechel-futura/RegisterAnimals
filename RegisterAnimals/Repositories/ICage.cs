using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{

    public interface IChangeCage<in T> where T : Animal
    {
        public void AddAnimal(T animal);
    }

    public interface IReadCage<out T> where T : Animal
    {
        T GetFirstAnimalInCage();
    }

    public interface ICage<T> : IReadCage<T>, IChangeCage<T> where T : Animal
    {       
    }
}
