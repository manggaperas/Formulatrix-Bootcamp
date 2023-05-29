using System;
using BookLibrary;

class Program
{
	static void Main(string[] args)
	{
		Buku[] buku = new Buku[3];

		buku[0] = new Buku("Tangkaplah Daku, Kau Kujitak", "Hilman Hariwijaya", 1986);
		buku[1] = new Buku("19+", "Boim Lebon", 2015);
		buku[2] = new Buku("Lupus Milenial", "Hilman Hariwijaya", 2005);

		Console.WriteLine("Informasi Buku:");
		foreach (var buku1 in buku)
		{
			Console.WriteLine($"Judul: {buku1.Judul}");
			Console.WriteLine($"Penulis: {buku1.Pengarang}");
			Console.WriteLine($"Tahun: {buku1.Tahun}");
			Console.WriteLine();
		}
	}
}
