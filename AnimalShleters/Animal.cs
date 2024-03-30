using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelters
{
    public class Animal : IAnimal
    {
        public string Vid { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }


        public Animal(string vid, int age, string name)
        {
            Vid = vid;
            Age = age;
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Вид: {Vid}, Возраст: {Age}");
        }
    }
}