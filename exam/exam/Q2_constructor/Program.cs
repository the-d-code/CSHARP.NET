using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Charlie", 2, "Bulldog");
        }

        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Animal(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("Animal play an essential role in human life ...");
            }
        }

        public class Dog : Animal
        {
            public string Breed { get; set; }

            public Dog(string name, int age, string breed) : base(name, age)
            {
                Breed = breed;
                Console.WriteLine("The dog breed is german Shepherd..");
            }
        }

    }
}
