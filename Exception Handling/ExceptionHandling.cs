namespace Exception_Handling;

public class ExceptionHandling
{
	public static void DivideByZeroException()
	{
		int num1 = 10;
		int num2 = 0;
		int result = num1 / num2;
		Console.WriteLine("Hasil pembagian: " + result); // Tidak akan dieksekusi
	}

	public static void ArrayOutOfRangeException()
	{
		int[] numbers = { 1, 2, 3, 4, 5 };
		Console.WriteLine("Elemen ke-10: " + numbers[9]); // Mencoba mengakses indeks di luar batas array
	}
	
	public static void IntegerInputByStringException()
	{
		int[] number = {2};
		number.ToString();
		Console.WriteLine("Angka yang tersedia: " + number);
	}
}
