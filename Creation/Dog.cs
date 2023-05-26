namespace AnimalLibrary;

public class Dog : Animal, IAnimalBehavior     //class dog inherited from animal and using interface
{
	public override void MakeSound()    //override method from child class
	{
		Console.WriteLine("The dog barks.");
	}

	public void Fetch()        //perilaku dari dog
	{
		Console.WriteLine("The dog fetches the ball.");
	}

	public void PerformBehavior()
	{
		Fetch();        //salah satu perilaku yang dimasukkan kedalam interface
	}
}
