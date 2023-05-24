using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		Dictionary<int, string> rules = new Dictionary<int, string>();
		rules.Add(3, "foo");
		rules.Add(5, "bar");
		rules.Add(7, "fizz");
		rules.Add(9, "buzz");

		Console.Write("Masukkan angka: ");
		int n = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("n = " + n);
		Console.Write("Hasil: ");

		for (int i = 1; i <= n; i++)
		{
			bool isDivisible = false;
			string result = "";

			foreach (var rule in rules)
			{
				if (i % rule.Key == 0)
				{
					result += rule.Value;
					isDivisible = true;
				}
			}

			if (!isDivisible)
				result = i.ToString();

			Console.Write(result + " ");
		}

		Console.WriteLine();
	}
}
