using System;
using System.IO;

namespace Chuckjokegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter te nr of jokes u want");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            GetJokes(usernumber);
        }
        private static void GetJokes(int Jokesnumber)
        {
            string filepath = @"C:\Users\opilane\samples\chuck.txt";
            string[] jokesaboutChuck = File.ReadAllLines(filepath); 

            if (Jokesnumber > jokesaboutChuck.Length)
            {
                Jokesnumber = jokesaboutChuck.Length;
            }

            for (int i = 0; i < Jokesnumber; i++)
            {
                Console.WriteLine(jokesaboutChuck[i]);
            }

        }
    }
}
