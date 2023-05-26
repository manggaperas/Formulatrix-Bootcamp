namespace AnimalLibrary;

public class Dog : Animal, IAnimalBehavior     //class dog inherited from animal and using interface
{
	public override void MakeSound()    //override method from child class
	{
		Display.Print("The dog barks.");
	}

	public void Fetch()        //perilaku dari dog
	{
		Display.Print("The dog fetches the ball.");
	}

	public void PerformBehavior()
	{
        MakeSound();
        Fetch();        //salah satu perilaku yang dimasukkan kedalam interface
	}
}
