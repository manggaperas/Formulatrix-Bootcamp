namespace AnimalLibrary;

public class Animal
{
    public string Name { get; set; }    //property

    public virtual void MakeSound() //method animal
    {
        Console.WriteLine("The animal makes a sound.");
    }
}
