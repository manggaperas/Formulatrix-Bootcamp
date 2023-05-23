public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Rectangle
{
    public Point TopLeft { get; set; }
    public Point BottomRight { get; set; }

    public int Width
    {
        get { return BottomRight.X - TopLeft.X; }
    }

    public int Height
    {
        get { return BottomRight.Y - TopLeft.Y; }
    }

    public int Area
    {
        get { return Width * Height; }
    }

    public Rectangle(Point topLeft, Point bottomRight)
    {
        TopLeft = topLeft;
        BottomRight = bottomRight;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Top Left: (" + TopLeft.X + ", " + TopLeft.Y + ")");
        Console.WriteLine("Bottom Right: (" + BottomRight.X + ", " + BottomRight.Y + ")");
        Console.WriteLine("Width: " + Width);
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("Area: " + Area);
    }
}

public class Count
{
    static void Main()
    {
        Point topLeft = new Point(1, 3);
        Point bottomRight = new Point(6, 1);
        Rectangle rectangle = new Rectangle(topLeft, bottomRight);

        rectangle.PrintInfo();
    }
}
