namespace CumpanyMANSYS.Genaric
{
    public interface IGenaricRepo<T> where T : class
    {
        Task Add(T entity);
        Task Update(int Id, T entity);

        void Delete(int Id);
        Task<T> Get(int Id);
        Task<List<T>> GetAll();
    }
}
