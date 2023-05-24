using System;

// membuat Interface
interface IAnimalBehavior
{
    void PerformBehavior();
}

// Parent Class
class Animal
{
    public string Name { get; set; }

    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Child Class dengan menggunakan Interface
class Dog : Animal, IAnimalBehavior
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }

    public void Fetch()
    {
        Console.WriteLine("The dog fetches the ball.");
    }

    public void PerformBehavior()
    {
        Fetch();
    }
}

// Child Class dengan menggunakan Interface
class Cat : Animal, IAnimalBehavior
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }

    public void Scratch()
    {
        Console.WriteLine("The cat scratches the furniture.");
    }

    public void PerformBehavior()
    {
        Scratch();
    }
}

// Generic class dengan merujuk Parent Class
class AnimalShelter<T> where T : Animal
{
    private T[] animals;

    public AnimalShelter(int capacity)
    {
        animals = new T[capacity];
    }

    public void AddAnimal(T animal)
    {
        for (int i = 0; i < animals.Length; i++)
        {
            if (animals[i] == null)
            {
                animals[i] = animal;
                Console.WriteLine($"Added {animal.Name} to the animal shelter.");
                return;
            }
        }

        Console.WriteLine("The animal shelter is full.");
    }

    public T GetAnimal(int index)
    {
        if (index >= 0 && index < animals.Length)
        {
            return animals[index];
        }

        Console.WriteLine("Invalid index.");
        return null;
    }

    // Event declaration
    public event EventHandler AnimalAdded;

    protected virtual void OnAnimalAdded()
    {
        AnimalAdded?.Invoke(this, EventArgs.Empty);
    }
}

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
