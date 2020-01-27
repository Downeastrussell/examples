using System;
using System.Collections.Generic;

namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>() {
                "Megan", "Damon", "Chase", "Tekisha",
                "Castle", "Mark", "Keith", "Adam",
                "Patrick", "Hannah", "Mike"
            };

            // Can't do this easily with a base array
            students.Add("Melanie");
            students.Insert(3, "Simon");

            if (students.Contains("Chase"))
            {
                Console.WriteLine("Must be cohort 13");
            }

            // This looks a lot like JavaScript!
            students.ForEach(student => Console.WriteLine(student));
        }
    }
}
