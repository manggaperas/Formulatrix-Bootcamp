using System.Reflection;

class Animal
{
	public void Eat()
	{
		Console.WriteLine("Animal is eating...");
	}
}

class Cat : Animal
{
	public void Meow()
	{
		Console.WriteLine("Cat is meowing...");
	}
}

class Result
{
	static void Main()
	{
		// Implicit Casting
		byte b = 10;
		int i = b;

		Console.WriteLine("Implicit Casting:");
		Console.WriteLine($"b = {b}, i = {i}");
		Console.WriteLine();

		// Explicit Casting
		double d = 3.14;
		int j = (int)d;

		Console.WriteLine("Explicit Casting:");
		Console.WriteLine($"d = {d}, j = {j}");
		Console.WriteLine();

		// Upcasting
		Animal animal = new Cat();

		Console.WriteLine("Upcasting:");
		animal.Eat();

		// Downcasting with 'as' operator
		Animal animal2 = new Animal();
		Cat cat = animal2 as Cat;

		Console.WriteLine("Downcasting with 'as' operator:");
		if (cat != null)
		{
			cat.Eat();
			cat.Meow();
		}
		else
		{
			Console.WriteLine("Failed to cast Animal to Cat.");
		}
		Console.WriteLine();

		// Downcasting with 'is' operator
		Animal animal3 = new Cat();

		Console.WriteLine("Downcasting with 'is' operator:");
		if (animal3 is Cat)
		{
			Cat cat2 = (Cat)animal3;
			cat2.Eat();
			cat2.Meow();
		}
		else
		{
			Console.WriteLine("Animal is not of type Cat.");
		}
		Console.WriteLine();

		// Using typeof()
		Type animalType = typeof(Animal);

		Console.WriteLine("Using typeof():");
		Console.WriteLine($"Name: {animalType.Name}");
		Console.WriteLine($"FullName: {animalType.FullName}");
		Console.WriteLine($"Namespace: {animalType.Namespace}");
		Console.WriteLine();

		Console.WriteLine("Methods in Animal class:");
		MethodInfo[] methods = animalType.GetMethods();

		foreach (MethodInfo method in methods)
		{
			Console.WriteLine(method.Name);
		}
	}
}
