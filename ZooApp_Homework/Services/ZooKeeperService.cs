using ZooApp_Homework.Exceptions;
using ZooApp_Homework.Models;
using ZooApp_Homework.Repositories;

namespace ZooApp_Homework.Services
{
    public class ZooKeeperService : IZooKeeperService
    {
        private readonly IZooKeeperRepository _zooKeeperRepository;
        public ZooKeeperService(IZooKeeperRepository zooKeeperRepository)
        {
            _zooKeeperRepository = zooKeeperRepository;
        }

        public void Add(ZooKeeper entity)
        {
            try
            {
                _zooKeeperRepository.Add(entity);
                GetList();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _zooKeeperRepository.Delete(id);
                GetList();
            }
            catch (ZooKeeperNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void GetById(int id)
        {
            try
            {
                ZooKeeper? zooKeeper = _zooKeeperRepository.GetById(id);
                Console.WriteLine(zooKeeper);
            }
            catch (ZooKeeperNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void GetList()
        {
            List<ZooKeeper> zooKeepers = _zooKeeperRepository.GetAll();
            foreach (var item in zooKeepers)
            {
                Console.WriteLine(item);
            }
        }

        public void Update(ZooKeeper entity)
        {
            try
            {
                _zooKeeperRepository.Update(entity);
                GetList();
            }
            catch (ZooKeeperNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
