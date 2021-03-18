namespace Uhaul.AnimalActions
{
	internal class Pterodactyl : Animal
	{
		public Pterodactyl()
		{
			AnimalName = "Pterodactyl";
		}

		public override string Eat()
		{
			return "viciously attacks its prey, devouring it in chunks.";
		}

		public override string LandOnTree()
		{
			return "ominously lands on a sturdy tree branch and glares at you hungrily.";
		}

		public override string Swim()
		{
			return "dives aggressively deeply into the water in pursuit of fish.";
		}
	}
}