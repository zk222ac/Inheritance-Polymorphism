using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Abstract_Interfaces
{
   public class Cat : Animal
    {
        private double _purrDB;      

        public Cat(int age, string name , double purrDB) : base(age, name)
        {
            _purrDB = purrDB;
        }
        public Cat()
        {

        }
        public double PurrDB { get => _purrDB; set => _purrDB = value; }

        public override void Sound()
        {
            Console.WriteLine("The cat says mao mao...");
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine("PurrDB:" + PurrDB);
        }
    }
}
