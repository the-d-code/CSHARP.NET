using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexerstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentData studdata = new StudentData(3);
            studdata[0] = new Student { Name = "Hemali", Age = 21 };
            studdata[1] = new Student { Name = "Rutvi", Age = 20 };
            studdata[2] = new Student { Name = "Devanshi", Age = 21 };

            Console.WriteLine(studdata[0].Name);         
            Console.WriteLine(studdata["Hemali"].Age);
            Console.WriteLine(studdata[1].Name);
            Console.WriteLine(studdata["Rutvi"].Age);
            Console.WriteLine(studdata[2].Name);
            Console.WriteLine(studdata["Devanshi"].Age);
        }

class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class StudentData
    {
        private Student[] stud;

        public StudentData(int size)
        {
            stud = new Student[size];
        }

        public Student this[int index]
        {
            get { return stud[index]; }
            set { stud[index] = value; }
        }

        public Student this[string name]
        {
            get
            {
                foreach (Student student in stud)
                {
                    if (student.Name == name)
                    {
                        return student;
                    }
                }
                return null;
            }
        }
    }
}
}
