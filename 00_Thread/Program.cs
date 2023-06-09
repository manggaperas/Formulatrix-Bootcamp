using System;
using System.Threading;

static class Program
{
    static void Main()
    {
        Thread Thread1 = new Thread(PrintNumbers);
        Thread Thread2 = new Thread(PrintNumbers);
        Thread1.Name = "Thread1";
        Thread2.Name = "Thread2";

        Thread1.Start();
        Thread2.Start();
        Thread1.Join();
        Thread2.Join();
    }

    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
            Thread.Sleep(1000);
        }
    }
}