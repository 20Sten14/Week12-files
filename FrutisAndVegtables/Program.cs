using System;
using System.IO;

namespace FrutisAndVegtables
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitpath = @"C:\Users\opilane\samples\fruit.txt";
            string[] veggiedata = File.ReadAllLines(fruitpath);
            string veggiepath = @"C:\Users\opilane\samples\Veggie.txt";
            string[] frutidata = File.ReadAllLines(veggiepath);

            File.WriteAllLines(fruitpath, frutidata);
            File.WriteAllLines(veggiepath, veggiedata);
        }
    }
}
