using System;
using System.Collections.Generic;

namespace Uhaul.AnimalActions
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				IList<IAnimal> animals = new List<IAnimal>();
				animals.Add(new Penguin());
				animals.Add(new Parrot());
				animals.Add(new Pterodactyl());
				animals.Add(new Duck());
				foreach (IAnimal animal in animals)
				{
					Console.WriteLine(AnimalActions.Swim(animal));
					Console.WriteLine(AnimalActions.LandOnTree(animal));
					Console.WriteLine(AnimalActions.Eat(animal));
					Console.WriteLine(AnimalActions.GetAnimalSound(animal));
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("There is an escaped animal at the zoo today! Please come another day! Thank you!");
			}
			Console.WriteLine("Hit ENTER to exit.");
			Console.ReadLine();
		}
	}
}
