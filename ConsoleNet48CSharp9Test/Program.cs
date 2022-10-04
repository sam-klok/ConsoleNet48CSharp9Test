using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNet48CSharp9Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Serg", "Klok");

            // is not null is c# 9.0 feature
            if (person is not null)
                Console.WriteLine($"Name: {person.FirstName} {person.LastName}");

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
