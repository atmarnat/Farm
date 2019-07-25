using System;
using FarmObjects;
using DoStuff;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
                DrawFarm.Welcome();
            try
            {
                Do.Stuff();
            }
            catch(Exception E)
            {
                Console.WriteLine(E);
            }
            finally
            {
                DrawFarm.Bye();
            }
        }
    }
}
