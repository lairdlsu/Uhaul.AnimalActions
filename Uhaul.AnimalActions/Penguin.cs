namespace Uhaul.AnimalActions
{
	internal class Penguin : Animal
	{

		public Penguin()
		{
			AnimalName = "Penguin";
		}

		public override string GetAnimalSound()
		{
			return "makes surprisingly loud penguin noises.";
		}

		public override string LandOnTree()
		{
			return "cannot land on a tree; It can't fly!";
		}

		public override string Swim()
		{
			return "tucks its tiny feet under it and spreads its wings wide to swim quickly underwater.";
		}
	}
}