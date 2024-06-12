/*
    • Create a Coordinate struct that can represent a room coordinate with a row and column
    • Ensure Coordinate is immutable.
    • Make a method to determine if one coordinate is adjacent to another (differing only by a single row or column).
    • Write a main method that creates a few coordinates and determines if they are adjacent to each other to prove that it is working correctly
*/

Coordinate c1 = new Coordinate(0, 0);
Coordinate c2 = new Coordinate(0, 1);

WriteLine($"{c1.ToString()}, {c2.ToString()}");
WriteLine($"Is c1 adjacent to c2 ==> {c1.IsAdjacentTo(c2)}");

public struct Coordinate
{
    public int Row;
    public int Column;

    public Coordinate(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public bool IsAdjacentTo(Coordinate other) // (differing only by a single row or column).
    {
        return Row == other.Row && Math.Abs(Column - other.Column) == 1
            || Column == other.Column && Math.Abs(Row - other.Row) == 1;
    }

    public override string ToString() => $"({Row}, {Column})";
}