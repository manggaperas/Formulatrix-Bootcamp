namespace AnimalLibrary;

public class Bird : Animal , IAnimalBehavior
{
	
	public override void MakeSound()
	{
		Console.WriteLine("The bird tweets");
	}
	
	public void Fly()
	{
		Console.WriteLine("The bird is flying");
	}
	
	public void PerformBehavior()
	{
		Fly();
	}
}
