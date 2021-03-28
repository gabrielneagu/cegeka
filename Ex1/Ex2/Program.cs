using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3] { 1, 8, 3 };
            string[] stringArray = new string[3] { "x", "b", "c" };
            GenericSwapClass<int>.Swap(array, 0, 2);
            foreach(int nr in array)
            {
                Console.WriteLine(nr);
            }
            GenericSwapClass<string>.Swap(stringArray, 0, 2);
            foreach (string letter in stringArray)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
