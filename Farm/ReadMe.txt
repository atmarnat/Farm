﻿Main.cs
	Calls Do class and has error handling

DoStuff.cs
	Handles user input and manages lists of stuff
		- public static void Stuff(): Handles most of the console input
		- private static bool Leave(): returns true to exit if chosen, or false to continue
		- private static string OptionsMenu(): shows options for tasks, accepts input and returns a string
		- private static string AnimalMenu(): Shows a list of the animals
		- private static Horse AddHorse(): Adds a horse to the horse list
		- private static Horse AddPig(): Adds a pig to the pig list
		- private static Horse AddChicken(): Adds a chicken to the chicken list
		- private static Horse AddSheep(): Adds a sheep to the sheep list
		- private static void Populate(): Adds some initial animals to the lists

FarmObjects.cs
	Contains a list of objects that are found on a farm
		- public class Animal(): A parent class for all animals
		- public static class DrawFarm(): Draws pictures to the console

Animals.cs
	Contains a list of objects that represent animals
		- public class Horse(): class to handle horse info
		- public class Pig(): class to handle Pig info
		- public class Chicken(): class to handle Chicken info
		- public class Sheep(): class to handle Sheep info
		- public class Other(): class to handle Custom info
	All classes should extend the Animal class


AnimalTest.cs
	Added some tests to make sure the animal classes worked correctly
	Implemented to test understanding of testing



### NOTE
	I could have used the Animal class to do everything and greatly simplified the code.
	However, the goal of the project was to create 4 classes of animals and test some methods in them. 
	Therefore I went this route.