using ZooApp_Homework.Exceptions;
using ZooApp_Homework.Models;

namespace ZooApp_Homework.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly List<Animal> _animals;

        public AnimalRepository()
        {
            _animals = new List<Animal>()
            {
                new(){ Id = 1 ,Age = 2,Name = "Alex",Type = "Lion",FoodType = "Carnivorous",Gender = "Male"},
                new(){ Id = 2 ,Age = 1,Name = "Zeus",Type = "Rhino",FoodType = "Herbivorous",Gender = "Male"},
                new(){ Id = 3 ,Age = 9,Name = "Loki",Type = "Cheetah",FoodType = "Carnivorous", Gender = "Male"},
                new(){ Id = 4 ,Age = 4,Name = "Angel",Type = "Giraffe",FoodType = "Herbivorous", Gender = "Female"},
                new(){ Id = 5 ,Age = 3,Name = "Lucy",Type = "Bear",FoodType = "Omnivore", Gender = "Female"},
                new(){ Id = 6 ,Age = 4,Name = "Afrodit",Type = "Hipopotamus",FoodType = "Herbivorous", Gender = "Female"},
                new(){ Id = 7 ,Age = 5,Name = "Hera",Type = "Elephant",FoodType = "Herbivorous", Gender = "Female"}
            };
        }

        public void Add(Animal entity)
        {
            _animals.Add(entity);
        }

        public void Delete(int id)
        {
            Animal animal = _animals.FirstOrDefault(x => x.Id == id);
            if (animal == null)
            {
                throw new AnimalNotFoundException(id);
            }
            _animals.Remove(animal);

        }

        public List<Animal> GetAll()
        {
            return _animals;
        }

        public Animal GetById(int id)
        {
            Animal animal = _animals.FirstOrDefault(x=> x.Id == id);

            if (animal == null)
            {
                throw new AnimalNotFoundException(id);
            }

            return animal;
        }

        public void Update(Animal entity)
        {
            Animal animal = _animals.FirstOrDefault(x => x.Id == entity.Id);
            if (animal == null)
            {
                throw new AnimalNotFoundException(entity.Id);
            }

            Delete(animal.Id);
            Add(entity);
        }
    }
}
