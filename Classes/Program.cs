using System;

public class Animal
{
    public string Name;
    public int Age;
    public int Weight;
    public int Height;
    public bool Gender;

    public Animal(string name, int age, int weight, int height, bool gender)
    {
        this.Name = name;
        this.Age = age;
        this.Weight = weight;
        this.Height = height;
        this.Gender = gender;
    }

    public void AnimalInfo()
    {
        Console.WriteLine("Name: {0}", this.Name);
        Console.WriteLine("Age: {0}", this.Age);
        Console.WriteLine("Weight: {0}", this.Weight);
        Console.WriteLine("Height: {0}", this.Height);
        Console.WriteLine("Gender: {0}", (this.Gender ? "Male" : "Female"));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal cotton = new Animal("Cotton", 2, 200, 120, true);
        cotton.AnimalInfo();
    }
}
