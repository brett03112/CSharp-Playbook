using static System.Console;

Point point = new Point(5, 6);

WriteLine($"X: {point.X}, Y: {point.Y}");

public class Point
{
    public float X {get; }
    public float Y {get; }

    
    
    //overloaded constructor
    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
    //properties with getters and setters and a default value
    public Point() : this(0, 0) { }

    
}

