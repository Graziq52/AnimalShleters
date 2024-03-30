using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelters
{
    public interface IAnimalShelter
    {
        void AddAnimal(Animal animal);
        void RemoveAnimal(Animal animal);
        List<Animal> SearchAnimals(string criteria, string value);
    }
}
