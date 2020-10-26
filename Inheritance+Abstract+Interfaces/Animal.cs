using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Abstract_Interfaces
{
   public class Animal
    {
        private int _age;
        private string _name;
        public Animal(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public Animal()
        {

        }
        public void Print()
        {
            Console.WriteLine("Age:" + Age);
            Console.WriteLine("Name:" + Name);
        }

        public virtual void Sound()
        {
            Console.WriteLine("The animal says something...");
        }

        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
