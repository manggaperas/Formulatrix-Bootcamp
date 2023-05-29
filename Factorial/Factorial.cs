/* Soal: Menghitung Faktorial */

// Tulislah sebuah program dalam bahasa C# untuk menghitung faktorial dari sebuah bilangan bulat yang diberikan.
// Faktorial dari sebuah bilangan n (dinyatakan sebagai n!) adalah hasil perkalian semua bilangan bulat positif
// dari 1 hingga n.

namespace FactorialLibrary;
using System;

public class Factorial
{
	public int bilangan { get; set; }

	public Factorial(int n)
	{
		this.bilangan = n;
	}

	public int HitungFaktorial()
	{
		int faktorial = 1;
		for (int i = 1; i <= bilangan; i++)
		{
			faktorial *= i;
		}
		return faktorial;
	}
}
