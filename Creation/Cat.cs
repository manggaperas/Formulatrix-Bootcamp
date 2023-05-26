namespace AnimalLibrary;

public class Cat : Animal, IAnimalBehavior     //class cat inherited dari animal dengan menggunakan interface
{
	public override void MakeSound()    //override method dari cat
	{
		Console.WriteLine("The cat meows.");
	}

	public void Scratch()       //perilaku kucing
	{
		Console.WriteLine("The cat scratches the furniture.");
	}

	public void PerformBehavior()
	{
		Scratch();      //perilaku yang dimasukkan kedalam interface
	}
}
