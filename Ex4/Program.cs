using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor
            {
                Name = "Asd Dsa",
                Faculty = "ETTI",
                Specialization = "inginer"

            };

            Professor p2 = new Professor
            {
                Name = "bls sds",
                Faculty = "AC",
                Specialization = "informatician"
            };

            Student s1 = new Student
            {
                Name = "Ion",
                Faculty = "ETTI",
                Year = 1
            };


            Student s2 = new Student
            {
                Name = "Vasile",
                Faculty = "ETTI",
                Year = 1
            };

            Student s3 = new Student
            {
                Name = "Csa",
                Faculty = "AC",
                Year = 2

            };

            Student s4 = new Student
            {
                Name = "Kjl",
                Faculty = "AC",
                Year = 2
            };

            Course c1 = new Course
            {
                Name = "C1",
                Profesor = p1,
                Year = 1,



            };
            c1.AddStd(s1.Name);
            c1.AddStd(s2.Name);

            Course c2 = new Course
            {
                Name = "C2",
                Profesor = p2,
                Year = 2

            };
            c2.AddStd(s3.Name);
            c2.AddStd(s4.Name);

            c1.Print();
            Console.WriteLine();
            c2.Print();
            Console.ReadLine();
        }
    }



    class Professor
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public void Print()
        {
            Console.WriteLine($"Nume:{Name}, faculty:{Faculty}, specialization:{Specialization}");
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int Year { get; set; }
        public void Print()
        {
            Console.WriteLine($"Student:{Name}, Faculty:{Faculty}, Year:{Year}");
        }


    }

    class Course
    {
        List<string> listastudenti = new List<string>();

        public string Name { get; set; }
        public Professor Profesor { get; set; }
        public int Year { get; set; }
        public void AddStd(string s)
        {
            listastudenti.Add(s);
        }

        public void Print()
        {
            Console.WriteLine($"Numele cursului: {Name}, Year: {Year}");
            Profesor.Print();
            Console.WriteLine("Lista studenti: ");
            for (int i = 0; i < listastudenti.Count; i++)
            {
                Console.WriteLine(listastudenti[i]);
            }
        }




    }
}
