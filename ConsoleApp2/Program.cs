using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("  Let's Figure Out Your Plan For This Weekend, Shall We?");
			Console.WriteLine("  What type of activity are you in the mood for?");
			Console.WriteLine("  Please select the number based on the matching mood! ");
			Console.WriteLine("   1 for Action, 2 for Chilling, 3 for Danger, and 4 for Good Food");
			string mood = (Console.ReadLine());

			Console.WriteLine("And how many companions will be joining you on this adventure?");
			Console.WriteLine("Press 1 for 0 companions, 2 for 1-4, 3 for 5-10, and 4 for 11+ companions");
			string companions = Console.ReadLine();


			if (mood == "1")
				{
					Console.WriteLine("You are in the mood for Action, you should go Stock Car Racing");
				}
				else if (mood == "2")
				{
					Console.WriteLine("You are in the mood for Chilling, you should go hiking"); ;
				}
				else if (mood == "3")
				{
				Console.WriteLine("You are in the mood for Danger, you should try SkyDiving");
				}
				else if (mood == "4")
				{
					Console.WriteLine("You are in the mood for Good Food, you should go to Taco Bell");
				}
				else
				{
					Console.WriteLine("Please make a valid mood selection based on the available options.");
				}

			if (companions == "1")
				{
					Console.WriteLine("and you should travel in sneakers");
				} else if (companions == "2")
				{
					Console.WriteLine("and you should travel in a sedan");
				} else if (companions == "3")
				{
					Console.WriteLine("and you should travel in a Volkswagon bus");
				} else if (companions == "4")
				{
					Console.WriteLine("and you should travel in an airplane");
				} else
				{
					Console.WriteLine("Please make a valid companion selection based on the available options.");
				}

			Console.WriteLine("Hope you have a wonderful adventure, Goodbye!");
			Console.ReadLine();
		}	
	}
}
