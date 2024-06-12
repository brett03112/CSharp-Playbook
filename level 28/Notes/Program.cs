/*
    Notes on Structs
    --A struct is a custom value type that defines a data structure withou complex behavior
    --Structs are value types that can have properties and methods
    --Structs are immutable by default and cannot be used in interfaces
    --Make structs small, immutable, and performant
    --All the builtin types are aliases for other structs
    --Structs are primarily useful for representing small data-related concepts that don’t have a lot of behavior.
    --keep them small. That is subjective, but an 8-byte struct is fine, while a 200-byte struct
        should generally be avoided. The costs of copying large structs add up.
    --Make them immutable.
    --Structs can exist without calling a constructor, a default, zeroed-out struct should represent a valid value. 
    --boxing can happen implicitly while unboxing can happen explicitly ie: object thing = 3; (boxing)\n int i = (int)thing; (unboxing)

    
    --Built-In Type Alias For: Class or Struct?
    bool        System.Boolean      struct
    byte        System.Byte         struct
    sbyte       System.SByte        struct
    char        System.Char         struct
    decimal     System.Decimal      struct
    double      System.Double       struct
    float       System.Single       struct
    int         System.Int32        struct
    uint        System.UInt32       struct
    long        System.Int64        struct
    ulong       System.UInt64       struct
    short       System.Int16        struct
    ushort      System.UInt16       struct
    string      System.String       class
    object      System.Object       class
*/

Point p1 = new Point(2,4);  // value type which contains data where the variable lives not a reference
WriteLine($"{p1.X}, {p1.Y}");

PairOfInts pair = new PairOfInts();
pair.A = 10;
pair.B = 20;
WriteLine($"{pair.A}, {pair.B}");

PairOfInts first = new PairOfInts(2, 10);
PairOfInts second = new PairOfInts();
second = first;
WriteLine($"{second.A}, {second.B}"); 

public struct Point
{
    public float X { get;}
    public float Y { get;}

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }
}

public struct PairOfInts
{
    public int A; //These are public fields, which are usually best avoided
    public int B;

    public PairOfInts(int a, int b)
    {
        A = a;
        B = b;
    }
}



    


