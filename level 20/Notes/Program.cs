/*
    This chapter deals with Properties within a class.
    Properties give you field like access while still protecting data with methods
    Ex:  public float Width{ get => width; set => width = value; }.  Then to
    use a property: rectangle.Width = 10;
*/

Rectangle r = new Rectangle(2,3);
r.Width = 5;
WriteLine($"A {r.Width} by {r.Height} rectangle has an area of {r.Area}");

Rectangle r2 = new Rectangle();
WriteLine($"A {r2.Width} by {r2.Height} rectangle has an area of {r2.Area}");


public class Rectangle
{
    private float width;
    private float height;
    public float Width { get; set; } = 5; // property set and get with a default value
    public float Height { get; set; } = 5;// property set and get with a default value
    public float Area => Width * Height;
    
    public Rectangle() { } // default constructor with no parameters
    public Rectangle(float width, float height)// constructor with parameters
    {
        Width = width;
        Height = height;
    }
    
}