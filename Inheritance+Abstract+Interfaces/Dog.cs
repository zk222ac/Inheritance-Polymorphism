using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Abstract_Interfaces
{
   public class Dog : Animal
    {
        private bool _canHunt;
        public Dog(int age, string name , bool canHunt) : base(age, name)
        {
            _canHunt = canHunt;
        }
        public Dog()
        {
                
        }

        public bool CanHunt { get => _canHunt; set => _canHunt = value; }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Canhunt:" + CanHunt);
        }
        public override void Sound()
        {
            Console.WriteLine("The Dog says wah waho...");
        }
    }
}
