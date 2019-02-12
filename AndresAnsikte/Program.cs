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
            // Killer objekt/klass
            Killer[] murder = new Killer[0];
            Console.WriteLine("1. Add killer\n2. Show all killers\n3. Exit");
            Console.Write("Choose function by inserting corresponding number: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        murder = AddKiller(murder);
                        break;
                    case 2:
                        ShowKillers(murder);
                        break;
                }
                Console.WriteLine("1. Add killer\n2. Show all killers\n3. Exit ");
                Console.Write("Choose function by inserting corresponding number: ");
                
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void ShowKillers(Killer[] murder)
        {
            Console.WriteLine("Displaying all added killers.");
            foreach (Killer killer in murder)
            {
                Console.WriteLine(killer.name + " is serving " + killer.years + " years in " + killer.jail);
                Console.WriteLine();
            }
        }

        private static Killer[] AddKiller(Killer[] murder)
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter sentenced years: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name of prison: ");
            string jail = Console.ReadLine();       
            
            Killer newValue = new Killer();
            newValue.name = name;
            newValue.years = years;
            newValue.jail = jail;
            
            int newLength = murder.Length + 1;

            Killer[] result = new Killer[newLength];

            for (int i = 0; i < murder.Length; i++)
            {
                result[i] = murder[i];
            }
                

            result[newLength - 1] = newValue;
            Console.WriteLine("Lägg till mer?");
            string svar = Console.ReadLine();
            Killer newValue1 = new Killer();
            Killer[] result1;
            while (svar == "Ja"||svar == "ja")
            {
                Console.Write("Enter the name: ");
                string name1 = Console.ReadLine();
                Console.Write("Enter sentenced years: ");
                int years1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter name of prison: ");
                string jail1 = Console.ReadLine();
                newValue1 = new Killer();
                newValue1.name = name1;
                newValue1.years = years1;
                newValue1.jail = jail1;

                int newLength1 = result.Length + 1;

                result1 = new Killer[newLength1];

                for (int i = 0; i < result.Length; i++)
                {
                    result1[i] = result[i];
                }
                result1[newLength1 - 1] = newValue1;
                result = result1;
                Console.WriteLine("Lägg till mer?");
                svar = Console.ReadLine();
            }

            return result;
         
        }
    }
}
