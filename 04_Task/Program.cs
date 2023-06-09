using System;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Task task = new Task(() => Console.WriteLine("Test Task"));
		// task.Start();

		// // task.Wait(); // Wait for the task to complete
		
		task.RunSynchronously();
		
		System.Console.WriteLine($"Status: {task.Status}");
		
		task.Dispose();
		
		Console.ReadLine();
	}
}
