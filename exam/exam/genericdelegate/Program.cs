using System;

namespace genericdelegate
{
    internal class Program
    {

        public delegate void GenDelegate<T>(T TValue);
        static void Main(string[] args)
        {
            GenDelegate<int> del = new GenDelegate<int>(Program.Function1);
            del(50);

            GenDelegate<float> floatdel = new GenDelegate<float>(Program.Function2);
            floatdel(30.5f);

            GenDelegate<Student> studdel = new GenDelegate<Student>(Program.Function3);
            Student s = new Student { age = 22, Name = "ABC" };
            studdel(s);

        }

        private static void Function3(Student stud)
        {
            Console.WriteLine(stud);
        }

        public static void Function1(int x)
        {
            Console.WriteLine("Your int value is : " + x);
        }

        public static void Function2(float y)
        {
            Console.WriteLine("Float value is : " + y);
        }
        
        internal class Student
        {
            public string Name { get; set; }
            public int age { get; set; }

            public override string ToString()
            {
                return "student name is " + Name +  " and age is " + age;
            }
        }
    }
}
