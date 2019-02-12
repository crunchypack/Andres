using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndresAnsikte
{
    class Program
    {
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
                        // Skriv över gamla vektorn
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
            //Skriv ut alla Killers
            foreach (Killer killer in murder)
            {
                Console.WriteLine(killer.name + " is serving " + killer.years + " years in " + killer.jail);
                Console.WriteLine();
            }
        }

        private static Killer[] AddKiller(Killer[] murder)
        {
            // Skriv in all info
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter sentenced years: ");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter name of prison: ");
            string jail = Console.ReadLine();
            // skapa ny Killer
            Killer newValue = new Killer();
            newValue.name = name;
            newValue.years = years;
            newValue.jail = jail;
            // Lagra int med längden på gamla vektorn
            int newLength = murder.Length + 1;
            // Skapa ny vektor med nya längden
            Killer[] result = new Killer[newLength];
            // Kopiera in gamla vektorn till den nya
            for (int i = 0; i < murder.Length; i++)
            {
                result[i] = murder[i];
            }

            // Lägg till nya killern i nya vektorn
            result[newLength - 1] = newValue;
            // Om man vill lägga till mer
            Console.WriteLine("Lägg till mer?");
            string svar = Console.ReadLine();
            // Skapa ny killer och vektor av killers
            Killer newValue1 = new Killer();
            Killer[] result1;
            while (svar == "Ja" || svar == "ja")
            {
                Console.Write("Enter the name: ");
                string name1 = Console.ReadLine();
                Console.Write("Enter sentenced years: ");
                int years1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter name of prison: ");
                string jail1 = Console.ReadLine();
                // Samma kod som tidigare 
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
                // Skriv över result
                result = result1;
                Console.WriteLine("Lägg till mer?");
                svar = Console.ReadLine();
            }
            // Returnera result
            return result;

        }
    }
}
