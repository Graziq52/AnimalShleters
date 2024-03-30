using AnimalShelters;
using System.ComponentModel;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {

        AnimalShelter shelter = new AnimalShelter();

        Animal animal1 = new Animal("Гиена", 6, "Рекс");
        shelter.AddAnimal(animal1);
        Animal animal2 = new Animal("Носорог", 10, "Мурка");
        shelter.AddAnimal(animal2);
        Animal animal3 = new Animal("Попугай", 1, "Кеша");
        shelter.AddAnimal(animal3);

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Добро пожаловать в зоопарк \nВыберите действие:");
            Console.WriteLine("1) Добавить животного\n2) Удалить животного\n3) Поиск животного\n4) Полный список животных \n5) Выход");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    
                    Console.WriteLine("Введите возраст:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите вид:");
                    string vid = Console.ReadLine();
                    Console.WriteLine("Введите Имя:");
                    string name = Console.ReadLine();
                    Animal newAnimal = new Animal(vid, age, name);
                    shelter.AddAnimal(newAnimal);
                    break;
                case "2":
                    Console.WriteLine("Напишите имя жвиотного, чтобы удалить:");
                    string animalName = Console.ReadLine();
                    Animal animalToRemove = shelter.SearchAnimals("Имя", animalName).FirstOrDefault();
                    if (animalToRemove != null)
                    {
                        shelter.RemoveAnimal(animalToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Животного нет в зоопарке.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Поиск по: \n1)Имени \n2)Возрасту \n3)Виду \n4)Выход");
                    string criteria = Console.ReadLine();
                    switch (criteria)
                    {
                        case "1":
                            Console.WriteLine("Введите Имя:");
                            string value = Console.ReadLine();
                            List<Animal> searchResults = shelter.SearchAnimals("Имя", value);
                            foreach (Animal result in searchResults)
                            {
                                result.DisplayInfo();
                            }
                            break;

                        case "2":
                            Console.WriteLine("Введите Возраст:");
                            string val = Console.ReadLine();
                            List<Animal> searchResult = shelter.SearchAnimals("Возраст", val);
                            foreach (Animal result in searchResult)
                            {
                                result.DisplayInfo();
                            }
                            break;

                        case "3":
                            Console.WriteLine("Введите Вид:");
                            string va = Console.ReadLine();
                            List<Animal> searchResul = shelter.SearchAnimals("Вид", va);
                            foreach (Animal result in searchResul)
                            {
                                result.DisplayInfo();
                            }
                            break;
                    }
                    break;
                case "4":
                    Console.WriteLine("Полный список добавленных животных:");
                    List<Animal> allAnimals = shelter.GetAllAnimals();
                    foreach (Animal animal in allAnimals)
                    {
                        animal.DisplayInfo();
                    }
                    break;
                case "5":
                    Console.WriteLine("Выход из программы управления зоопарком", exit=true);
                    break;

                default:
                    Console.WriteLine("Введите команду");
                    break;
            }
        }
    }
}