namespace Uhaul.AnimalActions
{
	internal class Duck : Animal
	{
		public Duck()
		{
			AnimalName = "Duck";
		}

		public override string Eat()
		{
			return "opens its bill, greedily shovels in food, and swallows as quicly as possible.";
		}

		public override string LandOnTree()
		{
			return "clumsily lands on a tree branch, then quickly falls off since its webbed feet cannot grip the branch.";
		}

		public override string GetAnimalSound()
		{
			return "quacks loudly";
		}
	}
}