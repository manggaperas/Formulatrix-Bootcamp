namespace AnimalLibrary;

public class Animal
{
	public string Name { get; set; }    //property

	public virtual void MakeSound() //method animal
	{
		Display.Print("Animal Make sound");
	}
}
