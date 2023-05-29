namespace BookLibrary;

public class Buku
{
	public string Judul { get; set; }
	public string Pengarang { get; set; }
	public int Tahun { get; set; }

	public Buku(string judul, string pengarang, int tahun)
	{
		Judul = judul;
		Pengarang = pengarang;
		Tahun = tahun;
	}
}