using System;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Task task = new Task(() => Console.WriteLine("Test Task"));
		task.Start();

		task.Wait(); // Wait for the task to complete
		
		task.Dispose();
		
		Console.ReadLine();
	}
}
