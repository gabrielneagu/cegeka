using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    public class SolarSystem
    {
        private List<string> planets;
        public SolarSystem()
        {
            planets = new List<string>();
        }
        public string Planets { get { return planets.AsReadOnly().ToString(); } }
        public void Add(string planet)
        {
            planets.Add(planet);
        }
        public void Insert(string planet, int index)
        {
            planets.Insert(index, planet);
        }
        public void Remove(string planet)
        {
            if (planets.Contains(planet))
            {
                planets.Remove(planet);
            }
            else
            {
                Console.WriteLine("The planet does not exist in this solar system.");
            }
        }
        public void Replace(string planet, int index)
        {
            if(index >= 0 && index < planets.Count)
            {
                planets[index] = planet;
            }
            else
            {
                Console.WriteLine("Index out of bounds.");
            }
        }
        public void Swap(int index1, int index2)
        {
           if(index1 >= 0 && index1 < planets.Count && index2 >= 0 && index2 < planets.Count)
            {
                string aux = planets[index1];
                planets[index1] = planets[index2];
                planets[index2] = aux;
            }
            else
            {
                Console.WriteLine("Index out of bounds");
            }
        }
        public void Reverse()
        {
            planets.Reverse();
        }
        public void Print()
        {
            foreach(string planet in planets)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
