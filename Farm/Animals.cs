using System;
using System.Collections.Generic;
using System.Text;
using FarmObjects;

namespace Animals
{
    public class Horse : Animal
    {
        public Horse()
        {
            SetDefaultVals("horse", "horse", "neigh", 4, "hay", "brown");
        }
        public void Draw()
        {
            Console.WriteLine("     >>\\.");
            Console.WriteLine("    /_  )`.");
            Console.WriteLine("   /  _)`^)`.   _.---. _");
            Console.WriteLine("  (_,' \\  `^-)\"\"      `.\\");
            Console.WriteLine("        |              | \\");
            Console.WriteLine("        \\              / |");
            Console.WriteLine("       / \\  /.___.'\\  (\\ (_");
            Console.WriteLine("      < ,\" ||     \\ |`. \\`-'");
            Console.WriteLine("       \\ ()      )|  )/");
            Console.WriteLine("       |_>|>     /_] //");
            Console.WriteLine("         /_]        /_]");
        }
    }
    public class Pig : Animal
    {
        public Pig()
        {
            SetDefaultVals("pig", "pig", "oink", 4, "everything", "pink");
        }
    }
    public class Chicken : Animal
    {
        public Chicken()
        {
            SetDefaultVals("chicken", "chicken", "bkaaw", 2, "seeds", "white");
        }
    }
    public class Sheep : Animal
    {
        public Sheep()
        {
            SetDefaultVals("sheep", "sheep", "baah", 4, "grass", "white");
        }
    }
    public class Other : Animal
    {
        public Other() { }
    }
}
