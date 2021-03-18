namespace Uhaul.AnimalActions
{
	internal interface IAnimal
	{
		public string AnimalName { get; set; }
		public string Swim();
		public string LandOnTree();
		public string Eat();
		public string GetAnimalSound();
	}
}