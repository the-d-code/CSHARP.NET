using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
class Animal
        {
            public string Name { get; set; }

            public Animal(string name)
            {
                Name = name;
            }

            public virtual void MakeSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
            }

            public override void MakeSound()
            {
                Console.WriteLine("The dog barks");
            }
        }

    }
}

