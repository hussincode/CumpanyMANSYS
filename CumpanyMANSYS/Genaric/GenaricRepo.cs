
using CumpanyMANSYS.Data;
using Microsoft.EntityFrameworkCore;

namespace CumpanyMANSYS.Genaric
{
    public class GenaricRepo<T> : IGenaricRepo<T> where T : class
    {
        private readonly DataContext dataContext;
        public GenaricRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task Add(T entity)
        {
             await dataContext.Set<T>().AddAsync(entity);
        }

        public  void Delete(int Id)
        {
            var entity = dataContext.Set<T>().Find(Id);
            if (entity != null) {
                dataContext.Set<T>().Remove(entity);
                    }
        }

        public async Task<T> Get(int Id)
        {
            return await dataContext.Set<T>().FindAsync(Id);
        }

        public Task<List<T>> GetAll()
        {
            return dataContext.Set<T>().ToListAsync();
        }

        public async Task Update(int Id, T entity)
        {
            entity = await dataContext.Set<T>().FindAsync(Id);
            if (entity != null)
            {
                dataContext.Set<T>().Update(entity);
            }
        }
    }
}
