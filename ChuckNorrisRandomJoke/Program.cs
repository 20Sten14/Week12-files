using System;
using System.IO;

namespace ChuckNorrisRandomJoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullfilepath = @"C:\Users\opilane\samples\chuck.txt";
            string[] jokeAboutchuck = File.ReadAllLines(fullfilepath);
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, jokeAboutchuck.Length);

            Console.WriteLine(jokeAboutchuck[randomIndex]);
            
        }


    }
}
