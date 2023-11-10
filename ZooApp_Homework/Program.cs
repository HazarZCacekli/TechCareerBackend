
using ZooApp_Homework.Repositories;
using ZooApp_Homework.Services;


IAnimalService animalService = new AnimalService(new AnimalRepository());
IZooKeeperService zooKeeperService = new ZooKeeperService(new ZooKeeperRepository());

animalService.GetList();
Console.WriteLine("---------------------------");
zooKeeperService.GetList();
Console.WriteLine("---------------------------");
