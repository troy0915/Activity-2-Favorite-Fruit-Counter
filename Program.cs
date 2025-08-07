using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2_Favorite_Fruit_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[5];
            int appleCount = 0;

            Console.WriteLine("Please enter your 5 favorite fruits:");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.Write($"Fruit {i + 1}: ");
                fruits[i] = Console.ReadLine().Trim().ToLower();
            }
            foreach (string fruit in fruits)
            {
                if (fruit == "apple")
                {
                    appleCount++;
                }
            }
            Console.WriteLine($"\nThe fruit 'apple' was entered {appleCount} time(s).");
        }
    }
}




