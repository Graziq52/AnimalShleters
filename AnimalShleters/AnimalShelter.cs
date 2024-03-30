using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelters
{
    public class AnimalShelter : IAnimalShelter
    {
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
           animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
            Console.WriteLine($"Удалено {animal.Name} с этого зоопарка.");
        }
        public List<Animal> SearchAnimals(string criteria, string value)
        {
            List<Animal> result = animals.FindAll(animal => criteria switch
            {
                "Вид" => animal.Vid.Equals(value, StringComparison.OrdinalIgnoreCase),
                "Возраст" => animal.Age.ToString().Equals(value),
                "Имя" => animal.Name.Equals(value, StringComparison.OrdinalIgnoreCase),
                _ => false
            }).ToList();

            return result;
        }
        public List<Animal> GetAllAnimals()
        {
            List<Animal> allAnimals = new List<Animal>();

            foreach (Animal animal in animals)
            {
                allAnimals.Add(animal);
            }

            return allAnimals;
        }
    }
}
