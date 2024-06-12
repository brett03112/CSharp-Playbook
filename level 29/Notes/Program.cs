/*
• Records are a compact alternative notation for defining a data-centric class or struct: public record Point(float X, float Y);

• The compiler automatically generates a constructor, properties, ToString, equality with value semantics, and deconstruction.

• You can add additional members or provide a definition for most compiler-synthesized members.

• Records are turned into classes by default or into a struct (public record struct Point(...)).

• Records can be used in a with expression: Point modified = p with { X = -2 };

• Records can be used as an alternative to tuples due to the ToString override and equality with value semantics and deconstruction.
*/

using System.Drawing;

Point a = new Point(2,3);
Point b = new Point(2,3);
WriteLine(a);
WriteLine(b);
WriteLine(a == b);

Point p = new Point(-2, 5);
(float x, float y) = p;
WriteLine(p);

Point p1 = new Point(-2, 5);
Point p2 = p1 with { X = 0 }; // using the 'with' statement
WriteLine(p2);

Point p3 = p1 with {X = 0, Y = 0};
WriteLine(p3);

// records
public record Point(float X, float Y) // That's all there is to it.
{
    public override string ToString() => $"({X}, {Y})";// Override ToString from records
}

public record ColoredPoint (Color color, float X, float Y) : Point(X, Y); // inheritance using a record




public record Rectangle(float Width, float Height)
{
    public float Area => Width * Height; // computed property
}

