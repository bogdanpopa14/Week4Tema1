using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBase b1 = new PizzaBase { Name = "Regular", Cost = 2 };
            PizzaBase b2 = new PizzaBase { Name = "Thick", Cost = 3 };
            PizzaBase b3 = new PizzaBase { Name = "Italian", Cost = 1.5 * b1.Cost };

            PizzaTopping t1 = new PizzaTopping { Name = "Cheese", Cost = 1.4 };
            PizzaTopping t2 = new PizzaTopping { Name = "SUNCA", Cost = 2 };
            PizzaTopping t3 = new PizzaTopping { Name = "Ardei", Cost = 3 };

            Pizza p1 = new Pizza { Name = "Quatro", Baza = b1 };
            p1.AddTop(t1);
            p1.AddTop(t2);
            p1.Print();

            Console.WriteLine();

            Pizza p2 = new Pizza { Name = "Full", Baza = b3 };
            p2.AddTop(t1);
            p2.AddTop(t2);
            p2.AddTop(t3);
            p2.Print();


            Console.ReadLine();





        }
    }

    class PizzaBase
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public void Print()
        {
            Console.WriteLine($"Blat: {Name} (${Cost})");
        }
    }

    class PizzaTopping

    {
        public string Name { get; set; }
        public double Cost { get; set; }



        public void Print()
        {
            Console.WriteLine($"{Name} (${Cost})");
        }


    }
    class Pizza
    {
        public string Name { get; set; }
        public PizzaBase Baza { get; set; }
        List<PizzaTopping> lista = new List<PizzaTopping>();

        public void AddTop(PizzaTopping top)
        {

            lista.Add(top);
        }

        public void Print()
        {
            double sum = 0;
            Console.WriteLine($"Pizza {Name}");
            Baza.Print();
            Console.WriteLine("Toppings:");
            for (int i = 0; i < lista.Count; i++)
            {

                lista[i].Print();
                sum += lista[i].Cost;
            }
            double cost = sum + Baza.Cost;
            Console.WriteLine($"Total Cost: ${cost}");
        }

    }

}
