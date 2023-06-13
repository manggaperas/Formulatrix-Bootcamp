using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Program Kecepatan Mengetik");
        Console.WriteLine("Tekan Enter untuk memulai...");
        Console.ReadLine();

        // string textlist = TextGenerator.GetRandomText();
        // Console.WriteLine(textlist);

        string testText = "Ini adalah tes kecepatan mengetik. Ketik teks ini secepat mungkin!";
        Console.WriteLine(testText);

        await Task.Run(async () =>
        {
            for (int i = 0; i < testText.Length; i++)
            {
                await Task.Delay(100); // Menunda eksekusi setiap karakter selama 100 ms
            }
        });

        Console.WriteLine("Ketik teks di atas secepat mungkin!");

        // Stopwatch stopwatch = null;
        // if (!string.IsNullOrEmpty(input))
        // {
        // 	stopwatch = new Stopwatch();
        // 	stopwatch.Start();
        // }
        // double elapsedTime = 0;
        // int charactersTyped = input.Length();

        // if (stopwatch != null)
        // {
        // 	stopwatch.Stop();
        // 	elapsedTime = stopwatch.ElapsedMilliseconds;
        // }

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        string input = Console.ReadLine();

        stopwatch.Stop();

        double elapsedTime = stopwatch.ElapsedMilliseconds;
        int charactersTyped = input.Length;

        double typingSpeed = charactersTyped / (elapsedTime / 60000); // Kecepatan mengetik dalam karakter per menit

        // if (charactersTyped > 0)
        // {
        // 	System.Console.WriteLine("Kecepatan Mengetik: " + typingSpeed.ToString("F2") + " karakter per menit.");
        // 	int score = CalculateTypingScore(charactersTyped, typingSpeed);
        // 	Console.WriteLine("Skor Mengetik: " + score);
        // }
        // else 
        // {
        // 	System.Console.WriteLine("Anda tidak mengetik apapun");
        // }
        // Console.WriteLine("Tekan Enter untuk keluar...");
        // Console.ReadLine();

        Console.WriteLine("Kecepatan Mengetik: " + typingSpeed.ToString("F2") + " karakter per menit.");

        int score = CalculateTypingScore(charactersTyped, typingSpeed);
        Console.WriteLine("Skor Mengetik: " + score);

        Console.WriteLine("Tekan Enter untuk keluar...");
        Console.ReadLine();
    }

    static int CalculateTypingScore(int charactersTyped, double typingSpeed)
    {
        // Menggunakan rumus sederhana untuk menghitung skor mengetik berdasarkan jumlah karakter dan kecepatan mengetik
        int score = (int)(charactersTyped * typingSpeed / 1000);
        return score;
    }
}
