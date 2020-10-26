using System;
using System.Collections.Generic;

namespace Inheritance_Abstract_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(12, "pomi", 100.00);
            cat.Print();
            Console.WriteLine(".........................");
            Dog dog = new Dog(23, "dami", true);
            dog.Print();
            Console.WriteLine(".........................");
            Animal animal = new Animal();
            animal.Sound();
            Console.WriteLine(".........................");
            Dog dog1 = new Dog();
            dog1.Sound();
            Console.WriteLine(".........................");
            Cat cat1 = new Cat();
            cat1.Sound();
            Console.WriteLine(".........................");
            Animal an = new Dog();
            an.Sound();
            Console.WriteLine(".......Dealing with List of animals ");
            List<Animal> zoo = new List<Animal>();
            zoo.Add(dog1);
            zoo.Add(cat1);
            zoo.Add(dog1);
            foreach (Animal a in zoo)
            {
                a.Sound();
            }



        }
    }
}
