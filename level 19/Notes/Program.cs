/*
 *  Notes on OOP programming concerning access modifiers(Private, Public, Internal, Protected)
 *  @author Brett Smith
 *  5/14/2024
 *
 *
*/

Rectangle rec = new Rectangle(10, 20);

WriteLine($"Width: {rec.GetWidth()}");
WriteLine($"Height: {rec.GetHeight()}");
WriteLine($"Area: {rec.GetArea()}");

// change the width and height
rec.SetWidth(15);
rec.SetHeight(25);
WriteLine($"Width: {rec.GetWidth()}");
WriteLine($"Height: {rec.GetHeight()}");
WriteLine($"Area: {rec.GetArea()}");


class Rectangle
{
private float _width;
private float _height;
public Rectangle(float width, float height)
{
    _width = width;
    _height = height;
}
public float GetWidth() => _width;
public float GetHeight() => _height;
public float GetArea() => _width * _height;
public void SetWidth(float value) => _width = value;
public void SetHeight(float value) => _height = value;
}