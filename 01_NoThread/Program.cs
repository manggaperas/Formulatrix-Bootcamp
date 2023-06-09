using System;
using System.Text;
using System.Diagnostics;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Starting program.");
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        DoTaskOne();
        DoTaskTwo();

        stopwatch.Stop();

        Console.WriteLine($"Program complete. Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
    }

    public static void DoTaskOne()
    {
        Console.WriteLine("Starting task 1.");
        StringBuilder x = new StringBuilder("Hello");
        x.AppendLine("Mangga");
        for (int i = 0; i < 10000; i++)
        {
            x.Append(i).Append(" ");
        }
        Console.WriteLine("Task 1 complete.");
    }


    public static void DoTaskTwo()
    {
        Console.WriteLine("Starting task 2.");
        StringBuilder y = new StringBuilder("Hello");
        y.AppendLine("Jeruk");
        for (int i = 0; i < 10000; i++)
        {
            y.Append(i).Append(" ");
        }
        Console.WriteLine("Task 2 complete.");
    }
}
