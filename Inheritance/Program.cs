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

public class Cat : Animal
{
    public string Species;
    public string Color;

    public Cat(string name, int age, int weight, int height, bool gender, string species, string color)
        : base(name, age, weight, height, gender)
    {
        this.Species = species;
        this.Color = color;
    }

    public void CatInfo()
    {
        Console.WriteLine("Species: {0}", this.Species);
        Console.WriteLine("Color: {0}", this.Color);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Cat cotton = new Cat("Cotton", 2, 200, 120, true, "Mix Anggora Persian", "White and Grey");
        cotton.AnimalInfo();
        cotton.CatInfo();
    }
}
