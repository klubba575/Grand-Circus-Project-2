using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealFunRecommendations
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("  What type of activity are you in the mood for?");
			Console.WriteLine("   1 for Action, 2 for Chilling, 3 for Danger, and 4 for Good Food");
			int mood = int.Parse(Console.ReadLine());
			string action = "Looks like you are in the mood for Action, you should try stock car racing ";
			string chilling = "Looks like you are in the mood for Chilling, you should try hiking ";
			string danger = "Looks like you are in the mood for Danger, you should try Sky Diving ";
			string goodFood = "Looks like you are in the mood for Good Food, you should go to Taco Bell ";
			string choice = null;

			if (mood == 1)
				{
					choice = action;
				}
				else if (mood == 2)
				{
					choice = chilling;
				}
				else if (mood == 3)
				{
					choice = danger;
				}
				else if (mood == 4)
				{
					choice = goodFood;
				}
				else
				{
					Console.WriteLine("Please make a valid mood selection based on the available options.");
				}
	
			Console.WriteLine("And how many companions will be joining you on this adventure?");
			int companions = int.Parse(Console.ReadLine());

			string companions1 = "in sneakers";
			string companions2 = "in a sedan";
			string companions3 = "in a Volkswagon bus";
			string companions4 = "in an airplane";
			string transportation = null;

			if (companions == 0)
			{
				transportation = companions1;

			} else if ((companions >= 1) && (companions <= 4))
			{
				transportation = companions2;

			} else if ((companions >= 5) && (companions <= 10))
			{
				transportation = companions3;

			} else if (companions >= 11)
			{
				transportation = companions4;

			} else
			{
				Console.WriteLine("Please enter a numerical value for your number of companions.");
			}
			Console.WriteLine(choice + transportation);
			Console.WriteLine("Hope you have a wonderful adventure, Goodbye!");
			Console.ReadLine();
		}	
	}
}
