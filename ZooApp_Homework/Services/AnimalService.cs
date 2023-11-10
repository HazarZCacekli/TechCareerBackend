using ZooApp_Homework.Exceptions;
using ZooApp_Homework.Models;
using ZooApp_Homework.Repositories;

namespace ZooApp_Homework.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public void Add(Animal entity)
        {
            try
            {
                _animalRepository.Add(entity);
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
                _animalRepository.Delete(id);
                GetList();
            }
            catch (AnimalNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void GetById(int id)
        {
            try
            {
                Animal? animal = _animalRepository.GetById(id);
                Console.WriteLine(animal);
            }
            catch (AnimalNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void GetList()
        {
            List<Animal> animals = _animalRepository.GetAll();
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }

        public void Update(Animal entity)
        {
            try
            {
                _animalRepository.Update(entity);
                GetList();
            }
            catch (AnimalNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
