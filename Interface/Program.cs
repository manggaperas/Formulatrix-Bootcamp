// Mendefinisikan sebuah antarmuka
public interface IShape
{
    double CalculateArea(); // Metode untuk menghitung luas
    void Display(); // Metode untuk menampilkan bentuk
}

// Mengimplementasikan antarmuka pada kelas Circle
public class Circle : IShape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public void Display()
    {
        Console.WriteLine("Circle");
    }
}

// Mengimplementasikan antarmuka pada kelas Rectangle
public class Rectangle : IShape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double CalculateArea()
    {
        return length * width;
    }

    public void Display()
    {
        Console.WriteLine("Rectangle");
    }
}

// Menggunakan antarmuka dalam program utama
class Program
{
    static void Main(string[] args)
    {
        IShape shape1 = new Circle(5);
        shape1.Display();
        Console.WriteLine("Area: " + shape1.CalculateArea());

        IShape shape2 = new Rectangle(3, 4);
        shape2.Display();
        Console.WriteLine("Area: " + shape2.CalculateArea());

        Console.ReadLine();
    }
}
