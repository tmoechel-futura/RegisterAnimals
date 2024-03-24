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

        public IEnumerable<Animal> GetAllAnimals()
        {
            return _dbSet.ToList();
        }

        public int GetElephantCount()
        {
            int numberOfElephants = _dbSet
                .OfType<Elephant>() 
                .Count();
            return numberOfElephants;
        }

        public int GetLionCount()
        {
            int numberOfElephants = _dbSet
                .OfType<Lion>() 
                .Count();
            return numberOfElephants;
        }
    }
}
