using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelectionDemo
{
    class Cat : Animal
    {
        private string _name;
        public int _old;
        public Cat()
        {
            _old = 10;
            _name = "susu";
        }

        public override void Cry()
        {
            Console.WriteLine("Meow !");
        }

        public override void PrintName()
        {
            Console.WriteLine("My name is {0}. i am a Cat.", _name);
        }
        public void SetName(string name)
        {
            this._name = name;
        }
        public void PrintAge()
        {
            Console.WriteLine("i am {0} years old", _old);
        }
    }
}
