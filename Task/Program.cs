using System;
using Foobar;

class Program
{
	static void Main()
	{
		var ruleDictionary = new RuleDictionary();
		var rules = ruleDictionary.GetRules();

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
