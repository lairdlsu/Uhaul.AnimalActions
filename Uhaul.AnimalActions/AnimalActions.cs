using System.Text;

namespace Uhaul.AnimalActions
{
	internal static class AnimalActions
	{
		public static string Swim(IAnimal animal)
		{
			StringBuilder output = new StringBuilder();
			output.Append(InitializeOutput(animal));
			output.AppendLine(animal.Swim());

			return output.ToString();
		}

		public static string LandOnTree(IAnimal animal)
		{
			StringBuilder output = new StringBuilder();
			output.Append(InitializeOutput(animal));
			output.AppendLine(animal.LandOnTree());

			return output.ToString();
		}

		public static string Eat(IAnimal animal)
		{
			StringBuilder output = new StringBuilder();
			output.Append(InitializeOutput(animal));
			output.AppendLine(animal.Eat());

			return output.ToString();
		}

		public static string GetAnimalSound(IAnimal animal)
		{
			StringBuilder output = new StringBuilder();
			output.Append(InitializeOutput(animal));
			output.AppendLine(animal.GetAnimalSound());

			return output.ToString();
		}

		private static string InitializeOutput(IAnimal animal)
		{
			StringBuilder output = new StringBuilder();
			output.Append("The ");
			output.Append(animal.AnimalName);
			output.Append(" ");

			return output.ToString();
		}
	}
}
