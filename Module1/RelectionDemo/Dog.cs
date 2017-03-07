using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelectionDemo
{
    class Dog:Animal
    {
        private string _name;
        public Dog()
        {
            _name = "Lulu";
        }
        public override void Cry()
        {
            Console.WriteLine("Woof");
        }

        public override void PrintName()
        {
            Console.WriteLine("My name is {0}. i am aDog.", _name);
        }
        public void SetName(string name)
        {
            this._name = name;
        }
    }
}
