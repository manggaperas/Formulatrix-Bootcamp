namespace CobaDispose;
using System;

class Percobaan : IDisposable
{
	private bool disposed = false;

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			if (disposing)
			{
				Console.WriteLine("1");
			}
			Console.WriteLine("2");
			disposed = true;
		}
	}
}