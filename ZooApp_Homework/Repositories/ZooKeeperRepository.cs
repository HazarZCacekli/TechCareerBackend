using ZooApp_Homework.Exceptions;
using ZooApp_Homework.Models;

namespace ZooApp_Homework.Repositories
{
    public class ZooKeeperRepository : IZooKeeperRepository
    {
        private readonly List<ZooKeeper> _zooKeepers;

        public ZooKeeperRepository()
        {
            _zooKeepers = new List<ZooKeeper>()
            {
                new(){Id = 1 ,Age = 22,Name = "Gustavo",Surname = "Fring",Gender = "Male",AnimalId = 3,Salary = 15000},
                new(){Id = 2, Age = 19, Name = "Saul", Surname = "Goodman", Gender = "Male", AnimalId = 5, Salary = 17000},
                new(){Id = 3, Age = 29, Name = "Walter",Surname = "White" , Gender = "Male",AnimalId = 2,Salary = 19000},
                new(){Id = 4, Age = 34, Name = "Jesse", Surname = "Pinkman", Gender = "Male", AnimalId = 1, Salary = 27000},
                new(){Id = 5, Age = 27, Name = "Mike", Surname = "Ehrmantraut", Gender = "Male", AnimalId = 4, Salary = 23000},
                new(){Id = 6, Age = 23, Name = "Hank",Surname = "Schrader" , Gender = "Male",AnimalId = 7,Salary = 14000},
                new(){Id = 7, Age = 56, Name = "Hector",Surname = "Salamanca" , Gender = "Male",AnimalId = 6,Salary = 55000}
            };
        }

        public void Add(ZooKeeper entity)
        {
            _zooKeepers.Add(entity);
        }

        public void Delete(int id)
        {
            ZooKeeper zooKeeper = _zooKeepers.FirstOrDefault(x => x.Id == id);
            if (zooKeeper == null)
            {
                throw new ZooKeeperNotFoundException(id);
            }
            _zooKeepers.Remove(zooKeeper);

        }

        public List<ZooKeeper> GetAll()
        {
            return _zooKeepers;
        }

        public ZooKeeper GetById(int id)
        {
            ZooKeeper zooKeeper = _zooKeepers.FirstOrDefault(x => x.Id == id);

            if (zooKeeper == null)
            {
                throw new ZooKeeperNotFoundException(id);
            }

            return zooKeeper;
        }

        public void Update(ZooKeeper entity)
        {
            ZooKeeper zooKeeper = _zooKeepers.FirstOrDefault(x => x.Id == entity.Id);
            if (zooKeeper == null)
            {
                throw new ZooKeeperNotFoundException(entity.Id);
            }

            Delete(zooKeeper.Id);
            Add(entity);
        }
    }
}
