/*
    Understanding static classes and methods
    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-methods

*/

public class Score
{
    public static readonly int PointThreshold;
    public static readonly int LevelThreshold;
    static Score()
    {
        PointThreshold = 1000;
        LevelThreshold = 4;
    }
}
//static properties and methods can be accessed without creating an instance of the class
public class Score{
    public static int PointThreshold {get; } = 1000;
    public static int LevelThreshold {get; } = 4;
}
//static methods can be called without creating an instance of the class
public static int CountForPlayer(string playerName, Score[] scores)
{
    int count = 0;
    foreach (Score score in scores)
    {
        if (score.Name == playerName)
        {
            count++;
        }
    }
    return count;
}

//a static class can't be instantiated. It is a collection of static methods or helper methods.
public static class Utilities
{
    public static int Helper1() => 4;
    public static double HelperProperty => 4.0;
    public static int AddNumbers(int a, int b) => a + b;
}