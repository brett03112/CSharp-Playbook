

Color a = new Color(10, 20, 30);
Color b = new Color(5,11,85);
Color c = Color.Black;

WriteLine($"a = {a.R}, {a.G}, {a.B}");
WriteLine($"b = {b.R}, {b.G}, {b.B}");
WriteLine($"Black = {c.R}, {c.G}, {c.B}");






public class Color
{
    public int R {get; }
    public int G {get; }
    public int B {get; }

    // overloaded constructor
    public Color(int red, int green, int blue)
    {
        R = red ;
        G = green ;
        B = blue ;
    }
    
    
    // static constructors for the predefined colors
    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black  { get; } = new Color(0, 0, 0);
    public static Color Red  { get; } = new Color(255, 0, 0);
    public static Color Green  { get; } = new Color(0, 255, 0);
    public static Color Blue  { get; } = new Color(0, 0, 255);
    public static Color Orange  { get; } = new Color(255, 165, 0);
    public static Color Yellow  { get; } = new Color(255, 255, 0);
    public static Color Purple  { get; } = new Color(128, 0, 128);
}