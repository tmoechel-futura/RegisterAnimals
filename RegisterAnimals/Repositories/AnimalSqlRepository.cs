using Microsoft.EntityFrameworkCore;
using RegisterAnimals.Data;
using RegisterAnimals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterAnimals.Repositories
{
    internal class AnimalSqlRepository<T> : IAnimalRepository<T> where T : Animal

    {
        private readonly AnimalDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public AnimalSqlRepository(AnimalDbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = _dbContext.Set<T>();
        }

        public void AddAnimal(T animal)
        {
            _dbContext.Add(animal);
            _dbContext.SaveChanges();
        }

        public int GetElephantCount()
        {
            // Query the number of Elephants
            int numberOfElephants = _dbSet
                .OfType<Elephant>() // Filter by Elephant type
                .Count();
            return numberOfElephants;
        }

        public int GetLionCount()
        {
            // Query the number of Elephants
            int numberOfElephants = _dbSet
                .OfType<Lion>() // Filter by Elephant type
                .Count();
            return numberOfElephants;
        }
    }
}
