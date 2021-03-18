namespace Uhaul.AnimalActions
{
	internal class Parrot : Animal
	{
		public Parrot()
		{
			AnimalName = "Parrot";
		}

		public override string GetAnimalSound()
		{
			return "makes cawww-caw-cawwww parrot sounds.";
		}

		public override string Swim()
		{
			return "cannot swim; Its a parrot!";
		}
	}
}