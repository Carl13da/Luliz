namespace LuLiz.Repository.Data.Base
{
    public interface IRepositoryBase<T>
    {
        T GetById(int id);
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
