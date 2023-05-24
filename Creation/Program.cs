using System;

// membuat Interface
interface IAnimalBehavior
{
    void PerformBehavior(); // method interface
}

// Parent Class
class Animal
{
    public string Name { get; set; }    //property

    public virtual void MakeSound() //method animal
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Child Class dengan menggunakan Interface
class Dog : Animal, IAnimalBehavior     //class dog inherited from animal and using interface
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

// Child Class dengan menggunakan Interface
class Cat : Animal, IAnimalBehavior     //class cat inherited dari animal dengan menggunakan interface
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

// Generic class dengan merujuk Parent Class
class AnimalShelter<T> where T : Animal     //ini merupakan generic class yang merujuk kepada parent class animal
{
    private T[] animals;        //array animals untuk mendata nama hewan yang terdaftar

    public AnimalShelter(int capacity)  //constructor dari class animalshelter
    {
        animals = new T[capacity];
    }

    public void AddAnimal(T animal)     //method untuk menambahkan animal
    {
        for (int i = 0; i < animals.Length; i++)    //kondisi untuk memasukkan animal kedalam daftar
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
