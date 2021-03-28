using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            SolarSystem solarSystem = new SolarSystem();
            solarSystem.Add("terra");
            solarSystem.Add("marte");
            solarSystem.Add("jupiter");
            solarSystem.Add("uranus");
            solarSystem.Add("saturn");
            Console.WriteLine("Toate planetele:");
            solarSystem.Print();

            solarSystem.Insert("corabia", 2);
            Console.WriteLine("Planetele dupa insert pe pozitia 2:");
            solarSystem.Print();

            solarSystem.Reverse();
            Console.WriteLine("Planetele dupa reverse:");
            solarSystem.Print();

            solarSystem.Replace("camin leu A", 3);
            Console.WriteLine("Planetele dupa replace pe pozitia 3:");
            solarSystem.Print();

            solarSystem.Replace("tataie", 6);
        }
    }
}
