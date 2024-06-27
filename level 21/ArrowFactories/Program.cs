Console.WriteLine("What arrow do you want?");
Console.WriteLine("1 - Elite Arrow");
Console.WriteLine("2 - Beginner Arrow");
Console.WriteLine("3 - Marksman Arrow");
Console.WriteLine("4 - Custom Arrow");

string? choice = Console.ReadLine();

Arrow arrow = choice switch
{
    "1" => Arrow.CreateEliteArrow(),
    "2" => Arrow.CreateBeginnerArrow(),
    "3" => Arrow.CreateMarksmanArrow(),
     _  => CreateCustomArrow(),
};

Console.WriteLine($"That arrow costs {arrow.Cost} gold.");



Arrow CreateCustomArrow()
{
    Arrowhead arrowhead = GetArrowheadType();
    Fletching fletching = GetFletchingType();
    float length = GetLength();

    return new Arrow(arrowhead, fletching, length);
}

Arrowhead GetArrowheadType()
{
    Console.Write("Arrowhead type (steel, wood, obsidian): ");
    string? input = Console.ReadLine();
#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
    return input switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian
    };
#pragma warning restore CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
}

Fletching GetFletchingType()
{
    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
    string? input = Console.ReadLine();
    #pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
    return input switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feather" => Fletching.TurkeyFeathers,
        "goose feather" => Fletching.GooseFeathers
    };
#pragma warning restore CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).
}

float GetLength()
{
    float length = 0;

    while (length < 60 || length > 100)
    {
        Console.Write("Arrow length (between 60 and 100): ");
        length = Convert.ToSingle(Console.ReadLine());
    }

    return length;
}
/// <summary>
/// A class representing an arrow
/// It has an arrowhead, fletching, and length
/// </summary>
public class Arrow
{
    public Arrowhead Arrowhead { get; }
    public Fletching Fletching { get; }
    public float Length { get; }

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }
    /// <summary>
    /// The cost of the arrow
    /// </summary>
    public float Cost
    {
        get
        {
            #pragma warning disable CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.
            float arrowheadCost = Arrowhead switch
            {
                Arrowhead.Steel => 10,
                Arrowhead.Wood => 3,
                Arrowhead.Obsidian => 5
            };
            #pragma warning restore CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.

            #pragma warning disable CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.
            float fletchingCost = Fletching switch
            {
                Fletching.Plastic => 10,
                Fletching.TurkeyFeathers => 5,
                Fletching.GooseFeathers => 3
            };
            #pragma warning restore CS8524 // The switch expression does not handle some values of its input type (it is not exhaustive) involving an unnamed enum value.

            float shaftCost = 0.05f * Length;

            return arrowheadCost + fletchingCost + shaftCost;
        }
    }
    /// <summary>
    /// Creates an elite arrow
    /// </summary>
    /// <returns></returns>
    public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
    /// <summary>
    /// Creates a beginner arrow
    /// </summary>
    /// <returns></returns>
    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75);
    /// <summary>
    /// Creates a marksman arrow
    /// </summary>
    /// <returns></returns>
    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);
}
/// <summary>
/// The different types of arrows
/// They have an arrowhead, fletching, and length
/// ArrowHead is an enum that has Steel, Wood, and Obsidian
/// Fletching is an enum that has Plastic, TurkeyFeathers, and GooseFeathers
/// </summary>
public enum Arrowhead { Steel, Wood, Obsidian }
public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }