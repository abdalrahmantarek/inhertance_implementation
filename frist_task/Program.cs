
using System;
using System.Security.Principal;

namespace frist_task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Manager m = new Manager(1, "ali", 176, 10);


            Maintenancy maintenancy = new Maintenancy(1, "ali", 176, 10);

            Devoloper devoloper = new Devoloper(1, "abdo", 180, 14, 0.05m, true);

            Sales sales = new Sales(1, "Mohamed", 176, 8,0.05m,10_000);
         
            Employee[] employee = { m, maintenancy, sales, devoloper };
            foreach (Employee e in employee) 
            {
                Console.WriteLine("\n----------------");
                Console.WriteLine(e);

            }
        }

    }
   
}

