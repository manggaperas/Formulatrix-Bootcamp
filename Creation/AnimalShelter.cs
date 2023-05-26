namespace AnimalLibrary;

public class AnimalShelter<T> where T : Animal     //ini merupakan generic class yang merujuk kepada parent class animal
{
	private T[] _animals;        //array animals untuk mendata nama hewan yang terdaftar

	public AnimalShelter(int capacity)  //constructor dari class animalshelter
	{
		_animals = new T[capacity];
	}

	public void AddAnimal(T animal)     //method untuk menambahkan animal
	{
		for (int i = 0; i < _animals.Length; i++)    //kondisi untuk memasukkan animal kedalam daftar
		{
			if (_animals[i] == null) 
			{
				_animals[i] = animal;
				Console.WriteLine($"Added {animal.Name} to the animal shelter.");
				return;
			}
		}

		Console.WriteLine("The animal shelter is full.");
	}

	public T GetAnimal(int index)
	{
		if (index >= 0 && index < _animals.Length)
		{
			return _animals[index];
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
