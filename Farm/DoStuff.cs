using System;
using System.Collections.Generic;
using System.Text;
using Animals;
using FarmObjects;

namespace DoStuff
{
    public static class Do
    {
        private static List<Horse> HorseList = new List<Horse>();
        private static List<Pig> PigList = new List<Pig>();
        private static List<Chicken> ChickenList = new List<Chicken>();
        private static List<Sheep> SheepList = new List<Sheep>();
        private static List<Other> OtherList = new List<Other>();
        public static void Stuff()
        {
            bool exit = false;
            while (exit == false)
            {
                string input = "";
				
				Console.WriteLine("Press Enter to Continue");
				Console.ReadKey();
				Console.Clear();
                DrawFarm.Welcome();
				Console.WriteLine("\n"+
                    "+-----------------------------------------+\n" +
                    "|========[}{}{}{]  HOWDY  [}{}{}{]========|\n" +
                    "+-----------------------------------------+\n");
                Console.WriteLine($"What would you like to do?");
                input = OptionsMenu();
                if (input == "1" || input == "Add animal")
                {
                    //TODO
                    Console.WriteLine("\nWhat kind of animal?");
                    input = AnimalMenu();
                    if (input == "1" || input == "Horse")
                    {
                        HorseList.Add(AddHorse());
                    }
                    if (input == "2" || input == "Pig")
                    {
                        PigList.Add(AddPig());
                    }
                    if (input == "3" || input == "Chicken")
                    {
                        ChickenList.Add(AddChicken());
                    }
                    if (input == "4" || input == "Sheep")
                    {
                        SheepList.Add(AddSheep());
                    }
                    else continue;

                }
                else if (input == "2" || input == "View animals")
                {
                    if (HorseList.Count + PigList.Count + SheepList.Count + ChickenList.Count > 0)
                    {
                        Console.WriteLine("\nHere are a list of the animals: ");
                        Console.WriteLine("-=- Horses -=-");
                        for (int i = 0; i < HorseList.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. " + HorseList[i].GetAbout());
                        }
                        Console.WriteLine("-=- Pigs -=-");
                        for (int i = 0; i < PigList.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. " + PigList[i].GetAbout());
                        }
                        Console.WriteLine("-=- Chickens -=-");
                        for (int i = 0; i < ChickenList.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. " + ChickenList[i].GetAbout());
                        }
                        Console.WriteLine("-=- Sheep -=-");
                        for (int i = 0; i < SheepList.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. " + SheepList[i].GetAbout());
                        }
                    }
                    else Console.WriteLine("\nThere are no animals!");

                }
                else if (input == "3" || input == "Remove Animal")
                {
                    Console.WriteLine("\nWhat is the type of the animal to remove: ");
                    input = AnimalMenu();
                    if(input == "1" || input == "Horse")
                    {
                        if (HorseList.Count > 0)
                        {
                            Console.Write("Name?: ");
                            input = Console.ReadLine();
                            for (int i = 0; i < HorseList.Count; i++)
                            {
                                if (input == HorseList[i].GetName()) HorseList.RemoveAt(i);
                                else if (i == HorseList.Count - 1) Console.WriteLine("This horse does not exist");
                            }
                        }
                        else Console.WriteLine("\nThere are no horses.");
                    }
                    if (input == "2" || input == "Pig")
                    {
                        if (PigList.Count > 0)
                        {
                            Console.Write("Name?: ");
                            input = Console.ReadLine();
                            for (int i = 0; i < PigList.Count; i++)
                            {
                                if (input == PigList[i].GetName()) PigList.RemoveAt(i);
                                else if (i == PigList.Count - 1) Console.WriteLine("This pig does not exist");
                            }
                        }
                        else Console.WriteLine("\nThere are no pigs.");
                    }
                    if (input == "3" || input == "Chicken")
                    {
                        if (ChickenList.Count > 0)
                        {
                            Console.Write("Name?: ");
                            input = Console.ReadLine();
                            for (int i = 0; i < ChickenList.Count; i++)
                            {
                                if (input == ChickenList[i].GetName()) ChickenList.RemoveAt(i);
                                else if (i == ChickenList.Count - 1) Console.WriteLine("This chicken does not exist");
                            }
                        }
                        else Console.WriteLine("\nThere are no chickens.");
                    }
                    if (input == "4" || input == "Sheep")
                    {
                        if (SheepList.Count > 0)
                        {
                            Console.Write("Name?: ");
                            input = Console.ReadLine();
                            for (int i = 0; i < SheepList.Count; i++)
                            {
                                if (input == SheepList[i].GetName()) SheepList.RemoveAt(i);
                                else if (i == SheepList.Count - 1) Console.WriteLine($"This sheep does not exist");
                            }
                        }
                        else Console.WriteLine("\nThere are no sheep.");
                    }
                    else continue;
                }
                else exit = Leave();
            }
        }
        private static bool Leave()
        {
            Console.Write("Would you like to exit (y/n)? ");
            string input = Console.ReadLine();
            if (input == "y" || input == "yes") return true;
            return false;
        }
        private static string OptionsMenu()
        {
            Console.WriteLine("\t1)Add Animal\t2)View Animals\t3)Remove Animal\t\t4)Exit");
            Console.Write("Make your choice: ");
            return Console.ReadLine(); ;
        }
        private static string AnimalMenu()
        {
            Console.WriteLine("\t1) Horse\t2) Pig\t\t3) Chicken\t4) Sheep");
            Console.Write("Make your choice: ");
            return Console.ReadLine();
        }
        private static Horse AddHorse()
        {
            Horse temp = new Horse();

            Console.Write("Enter the name: ");
            temp.SetName(Console.ReadLine());
            Console.Write("What color is it: ");
            temp.SetColor(Console.ReadLine());

            return temp;
        }
        private static Pig AddPig()
        {
            Pig temp = new Pig();

            Console.Write("Enter the name: ");
            temp.SetName(Console.ReadLine());
            Console.Write("What color is it: ");
            temp.SetColor(Console.ReadLine());

            return temp;
        }
        private static Chicken AddChicken()
        {
            Chicken temp = new Chicken();

            Console.Write("Enter the name: ");
            temp.SetName(Console.ReadLine());
            Console.Write("What color is it: ");
            temp.SetColor(Console.ReadLine());

            return temp;
        }
        private static Sheep AddSheep()
        {
            Sheep temp = new Sheep();

            Console.Write("Enter the name: ");
            temp.SetName(Console.ReadLine());
            Console.Write("What color is it: ");
            temp.SetColor(Console.ReadLine());

            return temp;
        }
    }
}
