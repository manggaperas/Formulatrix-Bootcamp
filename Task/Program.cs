using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Dictionary<int, string> rules = new Dictionary<int, string>()
		{
			{ 3, "foo" },
			{ 5, "bar" },
			{ 7, "fizz" },
			{ 9, "buzz" }
		};

		Console.Write("Masukkan angka: ");
		int n = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine($"n = {n}");
		Console.Write("Hasil: ");

		for (int i = 1; i <= n; i++)
		{
			bool divisible = false;
			foreach (var rule in rules)
			{
				if (i % rule.Key == 0)
				{
					Console.Write(rule.Value);
					divisible = true;
				}
			}
			if (!divisible)
				Console.Write(i);

			Console.Write(" ");
		}

		Console.WriteLine();
	}
}
