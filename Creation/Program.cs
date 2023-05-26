using AnimalLibrary;
using System;

class Program
{
	static void Main()
	{
		Dog dog = new Dog();
		dog.Name = "Buddy";

		Cat cat = new Cat();
		cat.Name = "Whiskers";

		Animal animal = dog;
		Dog castedDog = (Dog)animal;

		animal.MakeSound();
		castedDog.Fetch();

		cat.MakeSound();
		cat.Scratch();

		AnimalShelter<Animal> shelter = new AnimalShelter<Animal>(2);

		// Event handler
		shelter.AnimalAdded += Shelter_AnimalAdded;

		shelter.AddAnimal(dog);
		shelter.AddAnimal(cat);

		Animal retrievedAnimal1 = shelter.GetAnimal(0);
		if (retrievedAnimal1 != null)
		{
			Console.WriteLine($"Retrieved animal: {retrievedAnimal1.Name}");
		}

		Animal retrievedAnimal2 = shelter.GetAnimal(1);
		if (retrievedAnimal2 != null)
		{
			Console.WriteLine($"Retrieved animal: {retrievedAnimal2.Name}");
		}

		PerformBehaviorOnAnimal(dog);
		PerformBehaviorOnAnimal(cat);
	}

	static void Shelter_AnimalAdded(object sender, EventArgs e)
	{
		Console.WriteLine("An animal has been added to the shelter.");
	}

	static void PerformBehaviorOnAnimal(IAnimalBehavior animal)
	{
		Console.WriteLine($"Performing behavior on {animal.GetType().Name}:");
		animal.PerformBehavior();
	}
}
