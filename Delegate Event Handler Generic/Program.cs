using System;

public delegate void MyDelegate<T>(T data);

public class MyEventPublisher<T>
{
    public event MyDelegate<T> MyEvent;

    public void DoSomething(T data)
    {
        Console.WriteLine("Doing something interesting...");

        // Menggunakan pengkondisian untuk memicu event hanya jika data memenuhi kondisi tertentu
        if (data is int intValue && intValue > 0)
        {
            OnMyEvent(data);
        }
    }

    protected virtual void OnMyEvent(T data)
    {
        MyEvent?.Invoke(data);
    }
}

public class MyEventSubscriber
{
    public void MyEventHandler(int data)
    {
        Console.WriteLine($"Event handled by subscriber. Data: {data}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var publisher = new MyEventPublisher<int>();
        var subscriber = new MyEventSubscriber();

        // Menambahkan metode event handler ke event MyEvent pada publisher
        publisher.MyEvent += subscriber.MyEventHandler;

        // Memanggil metode DoSomething pada publisher dengan data yang berbeda
        publisher.DoSomething(10);  // Event akan dipicu dan handler akan dijalankan
        publisher.DoSomething(-5);  // Event tidak dipicu karena data tidak memenuhi kondisi
    }
}
