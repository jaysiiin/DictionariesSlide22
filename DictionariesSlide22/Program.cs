using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesSlide22
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            animals.Add("Bear", 4);
            animals.Add("Squid", 10);
            animals.Add("Bird", 2);
            animals.Add("Cat", 5);
            animals.Add("Dog", 8);
            animals.Add("Horse", 7);

            if(animals.ContainsKey("Bear"))
            {
                int value = animals["Bear"];
                Console.WriteLine("Bear has " + value + " legs.");
            }

            if (animals.ContainsKey("Chicken"))
            {
                int value = animals["Chicken"];
                Console.WriteLine("Bear has " + value + " legs.");
            }


        }
    }
}
