using System;
using System.IO;
using System.Threading.Tasks;

namespace FruitApp
{
    internal class CountFruits
    {
        private static async Task Main(string[] args)
        {
            // Ctrl+F5 to run
            var lines = await File.ReadAllLinesAsync("Fruits.txt");
            foreach (var line in lines)
            {
                //Print
                Console.WriteLine(line);
            }
        }
    }
}
