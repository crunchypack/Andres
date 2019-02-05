using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresAnsikte
{
    class Program
    {
         public static List<Killer> killers = new List<Killer>();
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add killer\n2. Show all killers\n3. Exit");
            Console.Write("Choose function by inserting corresponding number: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        AddKiller();
                        break;
                    case 2:
                        ShowKillers();
                        break;
                }
                Console.WriteLine("1. Add killer\n2. Show all killers\n3. Exit ");
                Console.Write("Choose function by inserting corresponding number: ");
                
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void ShowKillers()
        {
            Console.WriteLine("Displaying all added killers.");
            foreach (Killer killer in killers)
            {
                Console.WriteLine(killer.name + " is serving " + killer.years + " years in " + killer.jail);
                Console.WriteLine();
            }
        }

        private static void AddKiller()
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter sentenced years: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name of prison: ");
            string jail = Console.ReadLine();
            killers.Add(new Killer(name, years, jail));
            Console.WriteLine("");
           
        }
    }
}
