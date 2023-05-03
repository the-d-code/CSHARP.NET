using System;
using System.Collections.Generic;

namespace intrest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IClassFormatter> collection = new List<IClassFormatter>();
            int choice;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Class One instance");
                Console.WriteLine("2. Add Class Two instance");
                Console.WriteLine("3. Add Class Three instance");
                Console.WriteLine("4. Display all instances");
                Console.WriteLine("5. Display Class One instances");
                Console.WriteLine("6. Display Class Two instances");
                Console.WriteLine("7. Display Class Three instances");
                Console.WriteLine("0. Exit");

                Console.Write("\nEnter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;
                    case 1:
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter age: ");
                        int age = int.Parse(Console.ReadLine());
                        collection.Add(new ClassOne(name, age));
                        break;
                    case 2:
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();
                        collection.Add(new ClassTwo(title, author));
                        break;
                    case 3:
                        Console.Write("Enter brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Enter model: ");
                        string model = Console.ReadLine();
                        collection.Add(new ClassThree(brand, model));
                        break;
                    case 4:
                        Console.WriteLine("\nDisplaying all instances:");
                        foreach (IClassFormatter instance in collection)
                        {
                            instance.Display();
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nDisplaying Class One instances:");
                        foreach (IClassFormatter instance in collection)
                        {
                            if (instance is ClassOne)
                            {
                                instance.Display();
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("\nDisplaying Class Two instances:");
                        foreach (IClassFormatter instance in collection)
                        {
                            if (instance is ClassTwo)
                            {
                                instance.Display();
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("\nDisplaying Class Three instances:");
                        foreach (IClassFormatter instance in collection)
                        {
                            if (instance is ClassThree)
                            {
                                instance.Display();
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            } while (choice != 0);
        }
    }
    }
interface IClassFormatter
    {
        void Display();
    }

    class ClassOne : IClassFormatter
    {
        string name;
        int age;

        public ClassOne(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine("Class One: " + name + " - " + age);
        }
    }

    class ClassTwo : IClassFormatter
    {
        string title;
        string author;

        public ClassTwo(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Display()
        {
            Console.WriteLine("Class Two: " + title + " by " + author);
        }
    }

    class ClassThree : IClassFormatter
    {
        string brand;
        string model;

        public ClassThree(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public void Display()
        {
            Console.WriteLine("Class Three: " + brand + " " + model);
        }
    }

    
