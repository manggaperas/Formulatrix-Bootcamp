using System;
using FactorialLibrary;

class Program
{
	static void Main()
	{
		Console.Write("Masukkan bilangan bulat positif: ");
		int n = int.Parse(Console.ReadLine());

		int faktorial = HitungFaktorial(n);

		Console.WriteLine("Faktorial dari {0} adalah: {1}", n, faktorial);
		Console.ReadLine();
	}

	static int HitungFaktorial(int n)
	{
		if (n == 0)
			return 1;
		else
			return n * HitungFaktorial(n - 1);
	}
}
