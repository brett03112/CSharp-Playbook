/*
    Polymorphism

*/
WriteLine("Hello World!");
public class ChessPiece
{
    public int Row { get; set; }
    public int Column { get; set; }
    public virtual bool IsLegalMove(int row, int column) => IsOnBoard(row, column) && !IsCurrentLocation(row, column); // Abstract/virtual method.
    
    protected virtual bool IsOnBoard(int row, int column) => row >= 0 && row < 8 && column >= 0 && column < 8;
    
    protected virtual bool IsCurrentLocation(int row, int column) => row == Row && column == Column;
    
}

public class King : ChessPiece
{
    public override bool IsLegalMove(int row, int column) // Overriding
    {
        if (!IsLegalMove(row, column)) return false;

        // Moving more than one row or one column is not a legal king move.
        if (Math.Abs(row - Row) > 1) return false;
        if (Math.Abs(column - Column) > 1) return false;
            return true;
    }
}