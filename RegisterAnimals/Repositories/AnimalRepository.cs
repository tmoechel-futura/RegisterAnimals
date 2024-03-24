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
        List<Elephant> elephants = new List<Elephant>();

        public void AddLion(Lion lion)
        {
            lions.Add(lion);
        }

        public void AddElefant(Elephant elephant)
        {
            elephants.Add(elephant);
        }

        public int GetLionCount() { return lions.Count; }
        public int GetElephantCount() { return elephants.Count; }


    }
}
