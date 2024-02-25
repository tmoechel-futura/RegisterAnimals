using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{
    internal class AnimalRepository
    {
        List<Lion> lions = new List<Lion>();
        List<Elefant> elefants = new List<Elefant>();

        public void AddLion(Lion lion)
        {
            lions.Add(lion);
        }

        public void AddElefant(Elefant elefant)
        {
            elefants.Add(elefant);
        }

        public int GetLionCount() { return lions.Count; }
        public int GetElefantCount() { return elefants.Count; }


    }
}
