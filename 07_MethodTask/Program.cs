using System.Threading;
using System.Threading.Tasks;
using _07_MethodTask;

class Program
{
	static void Main()
	{
		// var task = Task.Run(() => Console.WriteLine("Hello from Task!"));
		var task = ThisAsync(token);
		// var result = task.Result;
		// task.Wait();
		Console.WriteLine("Press 'c' to cancel the operation.");
		if (Console.ReadKey().KeyChar == 'c')
		{
			cts.Cancel();
		}

		try
		{
			await task;
			Console.WriteLine("Operation completed.");
		}
		catch (OperationCanceledException)
		{
			Console.WriteLine($"IsCompleted: {task.IsCompleted}");
			Console.WriteLine($"IsFaulted: {task.IsFaulted}");
			Console.WriteLine($"IsCanceled: {task.IsCanceled}");
			Console.WriteLine("Operation canceled.");
		}
		finally
		{
			System.Console.WriteLine($"Status: {task.Status}");
		}


		// Console.WriteLine($"Status: {task.Status}");
		// Console.WriteLine($"IsCompleted: {task.IsCompleted}");
		// Console.WriteLine($"IsFaulted: {task.IsFaulted}");
		// Console.WriteLine($"IsCanceled: {task.IsCanceled}");
	}
}
