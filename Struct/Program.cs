using System;

// Mendefinisikan struct dengan nama "Person"
struct Person
{
    public string Name;   // Field "Name" dengan tipe data string
    public int Age;       // Field "Age" dengan tipe data int
}

class Program
{
    static void Main()
    {
        // Membuat instansiasi struct "Person"
        Person person1;

        // Mengisi nilai field "Name" dan "Age" pada struct "person1"
        person1.Name = "Angga";
        person1.Age = 26;

        // Menampilkan nilai field "Name" dan "Age" pada struct "person1"
        Console.WriteLine("Person 1:");
        Console.WriteLine("Name: " + person1.Name);
        Console.WriteLine("Age: " + person1.Age);
        Console.WriteLine();

        // Membuat instansiasi struct "Person" dengan menggunakan inisialisasi langsung
        Person person2 = new Person()
        {
            Name = "Kinara",
            Age = 25
        };

        // Menampilkan nilai field "Name" dan "Age" pada struct "person2"
        Console.WriteLine("Person 2:");
        Console.WriteLine("Name: " + person2.Name);
        Console.WriteLine("Age: " + person2.Age);

        // Menunggu pengguna menekan tombol sebelum keluar dari program
        Console.ReadKey();
    }
}
