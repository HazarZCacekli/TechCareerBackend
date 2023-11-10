using System.Security.Cryptography;

namespace ZooApp_Homework.Services
{
    public interface IGenericService<T> where T : class
    {
        void GetList();
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        void GetById(int id);
    }
}
