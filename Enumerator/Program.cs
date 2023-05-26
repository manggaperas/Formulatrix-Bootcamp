using Enumerator;

public class Program
{
	public static void Main(string[] args)
	{
		Enumeratorx enumerator = new Enumeratorx();

        foreach (string fruit in enumerator)
        {
            Console.WriteLine(fruit);
        }
	}
}
