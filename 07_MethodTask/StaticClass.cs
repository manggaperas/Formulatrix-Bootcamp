namespace _07_MethodTask;
using System.Threading;
using System.Threading.Tasks;

public static async Task ThisAsync(CancellationToken token)
{
	for (int i = 0; i <= 10; i++)
    {
        token.ThrowIfCancellationRequested();

        Console.WriteLine($"Work in progress: {i * 10}%");
        await Task.Delay(500, token);
    }
}
