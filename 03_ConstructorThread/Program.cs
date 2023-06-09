using System;
using System.Threading;

class Program
{
	static void Main()
	{
		//Create a new thread
		Thread t0 = new Thread(DoWorkSimple);
		t0.Start();

		// Create a new thread using the ThreadStart delegate
		Thread t1 = new Thread(new ThreadStart(DoWorkSimple));
		t1.Start();

		// Create a new thread using the ParameterizedThreadStart delegate
		Thread tp0 = new Thread(new ParameterizedThreadStart(DoWorkWithParameter));
		tp0.Start("parameter");

		// Create a new thread with a custom stack size
		Thread t2 = new Thread(new ThreadStart(DoWorkSimple), 1024 * 1024); // 1 MB stack size
		t2.Start();

		// Create a new thread with a name
		Thread t3 = new Thread(new ThreadStart(DoWorkSimple));
		t3.Name = "Named Thread";
		t3.Start();

		// Create new thread that call parameterized
		Thread tp1 = new Thread(() => DoWorkWithParameter("parameter2"));
		tp1.Start();

		// Create new thread that call parameterized
		Thread tp2 = new Thread(DoWorkWithParameter);
		tp2.Start("parameter3");
	}

	static void DoWorkSimple()
	{
		Console.WriteLine($"Simple work {Thread.CurrentThread.Name}: Thread ID={Thread.CurrentThread.ManagedThreadId}");
	}

	static void DoWorkWithParameter(object param)
	{
		Console.WriteLine($"Parameterized work {Thread.CurrentThread.Name}: Thread ID={Thread.CurrentThread.ManagedThreadId}, Parameter='{param}'");
	}
}
