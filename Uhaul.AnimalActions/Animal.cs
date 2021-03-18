namespace Uhaul.AnimalActions
{
	class Animal : IAnimal
	{
		public virtual string AnimalName { get; set; }

		public virtual string Eat()
		{
			return "opens its beak, bites food, and swallows.";
		}

		public virtual string GetAnimalSound()
		{
			return "makes interesting noises.";
		}

		public virtual string LandOnTree()
		{
			return "gracefully lands on a sturdy tree branch.";
		}

		public virtual string Swim()
		{
			return "kicks its feet to calmly swim across the water surface.";
		}

		public Animal()
		{
			AnimalName = "Animal";
		}
	}
}
