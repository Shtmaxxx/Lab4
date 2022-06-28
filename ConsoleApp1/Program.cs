using ConsoleApp1.Components;
using ConsoleApp1.Composites;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("System Block Instance: ");
            Product systemBlock = new SystemBlock("ASUS System Block", "13213213", 60);
            Product processor = new Processor("Intel Core i7", "8481239", 350, "Intel", 3.5, 8);
            Product ram = new RAM("Computer RAM", "3898124", 50, 8);
            Product gpu = new GPU("Nvidia GTX 1050", "43274821", 200, "Nvidia", 4);

            systemBlock.Add(processor);
            systemBlock.Add(ram);
            systemBlock.Add(gpu);
            systemBlock.Print();

            Console.WriteLine("\nComputer Instance: ");
            Computer computer = new Computer("Computer Complete", "84189237", 0);
            Product monitor = new Monitor("Monitor", "8348912", 300, 27, "LG", "1920x1080");

            computer.Add(systemBlock);
            computer.Add(monitor);
            computer.Print();
        }
    }
}
