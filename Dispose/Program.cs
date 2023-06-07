using CobaDispose;
using System;
class Program
{
	static void Main()
	{
		using (Percobaan Coba = new Percobaan())
		{
			Console.WriteLine("3");
		}
		Percobaan CobaLagi = new Percobaan();
		Console.ReadLine();
	}
}