/*
* Define a new Point class with properties for X and Y.
• Add a constructor to create a point from a specific x- and y-coordinate.
• Add a parameterless constructor to create a point at the origin (0, 0).
• In your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the
  console window in the format (x, y) to illustrate that the class works.
• Answer this question: Are your X and Y properties immutable? Why did you choose what you did?

*/



namespace level_24;

public class Point
{
    public float X { get; } = 0;
    public float Y { get; } = 0;

    public Point(float x, float y)
    {
      X = x;
      Y = y;
    }
    
    public override string ToString()
    {
      return $"({X}, {Y})";
    }
}
