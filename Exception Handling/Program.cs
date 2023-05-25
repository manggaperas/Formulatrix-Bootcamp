using System;
using Exception_Handling;

class Program
{
	static void Main()
	{
		try
		{
			// try pertama
			ExceptionHandling.DivideByZeroException();
		}
		catch (ArithmeticException e)
		{
			// catch untuk ArithmeticException
			Console.WriteLine("Terjadi kesalahan pembagian: " + e.Message);
		}
		finally
		{
			// finally pertama
			Console.WriteLine("Cek selesai");
		}

		try
		{
			ExceptionHandling.ArrayOutOfRangeException();
		}
		catch (IndexOutOfRangeException e)
		{
			// catch untuk IndexOutOfRangeException
			Console.WriteLine("Terjadi kesalahan indeks array: " + e.Message);
		}
		finally
		{
			// finally kedua
			Console.WriteLine("cek selesai");
		}

		try
		{
		ExceptionHandling.IntegerInputByStringException();
		}
		catch (FormatException e)
		{
			// catch untuk FormatException
			Console.WriteLine("Terjadi kesalahan input: " + e.Message);
		}
		finally
		{
			// finally
			Console.WriteLine("Program telah dicek");
		}
		
		// Program dilanjutkan setelah semua blok try-catch-finally
		Console.WriteLine("Program selesai");
	}
}
