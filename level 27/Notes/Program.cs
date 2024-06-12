/*
    Notes on Interfaces

    https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#interfaces
    --Use the interface keyworrd instead of class
    --members are public and abstract
    --no need to implement the interface
    --when used in a class, the class must implement the interface(define the methods within the interface)
    --classes can implement multiple interfaces

    https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8#interface-methods
    --they form a contract or specification of the methods that a class must implement

    --default implementation of interface methods can be used to simplify code where an interface implements multiple classes
    --
*/

/*
public interface ILevelBuilder
{
    Level BuildLevel(int levelNumber);
    int Count {get; }

    Level[] BuildAllLevels()
    {
        Level[] levels = new Level[Count];

        for (int Index = 1; Index <= Count; Index++)
            levels[Index - 1] = BuildLevel(Index);
        
        return levels;
    }
}

public class FixedLevelBuilder : ILevelBuilder
{
    public Level BuildLevel(int levelNumber)
    {
        Level level = new Level(10, 10, TerrainType.Forests);

        level.SetTerrainAt(2, 4, TerrainType.Mountains);
        level.SetTerrainAt(2, 5, TerrainType.Mountains);
        level.SetTerrainAt(6, 1, TerrainType.Desert);

        return level;

    }
}

public enum TerrainType { Desert, Forests, Mountains, Pastures, Fields, Hills }

*/

WriteLine("hello");