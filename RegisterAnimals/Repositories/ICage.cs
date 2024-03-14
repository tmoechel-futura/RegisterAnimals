using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{
    
    public interface ICage<out T> where T : Animal
    {
        //public void AddAnimal(T animal); this will not work yet

        void AddLion(Lion lion);
        T GetFirstAnimalInCage();

    }
}
