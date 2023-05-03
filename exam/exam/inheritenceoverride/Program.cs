using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritenceoverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Sound();         
            animal.Sound("CAW...CAW...CAW...");   

            Dog dog = new Dog();       
            dog.Sound("Barks");      
            dog.Sound(2);           
        }

        // Base class
        class Animal
        {
            public virtual void Sound()
            {
                Console.WriteLine("The animal makes a sound is diffrent type of voice..");
            }

            public void Sound(string sound)
            {
                Console.WriteLine("The animal makes a " + sound + " sound");
            }
        }

        // Derived class
        class Dog : Animal
        {
            public override void Sound()
            {
                Console.WriteLine("The dog is barks");
            }

            public void Sound(int numberofbarks)
            {
                for (int i = 0; i < numberofbarks; i++)
                {
                    Console.WriteLine("The dog is barks " + numberofbarks + " times" );
                }
            }
        }
    }
}
