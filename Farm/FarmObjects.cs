using System;
using System.Collections.Generic;
using System.Text;

namespace FarmObjects
{
    public class Animal
    {
        private string animal;
                string name;
                string sound;
                int legs;
                string food;
                string color;
        public Animal() { }
        public void SetDefaultVals(string animal, string name, string sound, int legs, string food, string color)
        {
            this.animal = animal;
            this.name = name;
            this.sound = sound;
            this.legs = legs;
            this.food = food;
            this.color = color;
        }
        public void SetAnimal(string t) => animal = t;
        public string GetAnimal() => animal;
        public void SetName(string n) => name = n;
        public string GetName() => name;
        public void SetSound(string s) => sound = s;
        public string GetSound() => sound;
        public void SetNumLegs(int n) => legs = n;
        public int GetNumLegs() => legs;
        public void SetFood(string f) => food = f;
        public string GetFood() => food;
        public void SetColor(string c) => color = c;
        public string GetColor() => color;
        public void About()
        {
            Console.WriteLine($"Hello, my name is {name}. I am a {animal}. I have {legs} legs, eat {food}, and am {color}.");
        }
        public string GetAbout()
        {
            return $"Hello, my name is {name}. I am a {animal}. I have {legs} legs, eat {food}, and am {color}.";
        }
    }
    public static class DrawFarm
    {
        public static void Welcome()
        {
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            Console.WriteLine("|                       Welcome to the Happy Farm!                              |");
            Console.WriteLine("|                      We have all types of animals                             |");
            Console.WriteLine("+-------------------------------------------------------------------------------+");
        }
        public static void Bye()
        {
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            Console.WriteLine("|                            Leaving so soon?                                   |");
            Console.WriteLine("|                        Ya'll come back, y'hear                                |");
            Console.WriteLine("+-------------------------------------------------------------------------------+");
        }
    }
}
