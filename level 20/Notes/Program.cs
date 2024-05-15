/*
    This chapter deals with Properties within a class.
    Properties give you field like access while still protecting data with methods
    Ex:  public float Width{ get => width; set => width = value; }.  Then to
    use a property: rectangle.Width = 10;
*/

Rectangle r = new Rectangle(2,3);
r.Width = 5;
WriteLine($"A {r.Width} by {r.Height} rectangle has an area of {r.Area}");


public class Rectangle
{
    private float _width;
    private float _height;
    public Rectangle(float width, float height)
    {
        _width = width;
        _height = height;
    }
    // Properties
    public float Width
    {
        get => _width;
        set => _width = value;
    }
    //Properties    
    public float Height
    {
        get => _height;
        set => _height = value;
    }
    public float Area => _width * _height;
}