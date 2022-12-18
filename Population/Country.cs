using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Population
{
    internal class Country
    {
        public string Name;
        public int TotalPopulation;
        City[] cities = new City[0];

        public void addCity (City Cities)
        {
            Array.Resize(ref cities, cities.Length + 1);
            cities[cities.Length - 1] = Cities;
        }

        public Country(string name, int totalPopulation)
        {
            Name = name;
            TotalPopulation = totalPopulation;
        }

        public void FindAllByPopulation(int min, int max)
        {
            Console.WriteLine($"{min} ve {max} araligindaki insanlara sahib seherler: ");
            foreach (City item in cities)
            {
                if (min <= item.Population && item.Population <= max)
                {
                    Console.WriteLine(item);
                }   
            }

        }
    }
}
