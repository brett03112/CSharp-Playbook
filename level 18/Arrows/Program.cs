/*
    Construct an arrow class with the folowing specifications:

    ---Each arrow has three parts: the arrowhead (steel, wood, or obsidian)
    ---the shaft (a length between 60 and 100 cm long)
    ---the fletching (plastic, turkey feathers, goose feathers)
    
    --- steel = 10 gold, wood = 5 gold, obsidian = 3 gold
    --- plastic = 10 gold, turkey feathers = 5 gold, goose feathers = 3 gold
    --- shaft is .05 gold per cm
*/

Console.WriteLine("Each arrow has 3 parts: the arrowhead (steel, wood, or obsidian), the shaft (a length between 60 and 100 cm long), " +
            "and the fletching (plastic, turkey feathers, goose feathers).");
Console.WriteLine("Enter the arrowhead type:");
string? arrowHead = Console.ReadLine();
arrowHead = arrowHead.ToLower();

Console.WriteLine("Enter the fletching type:");
string? fletching = Console.ReadLine();
fletching = fletching.ToLower();

Console.WriteLine("Enter the shaft length:");
int shaftLength = Convert.ToInt32(Console.ReadLine());

Arrow arrow = new Arrow(arrowHead, fletching, shaftLength);
decimal cost = arrow.CalculateCost(arrowHead, fletching, shaftLength);

Console.WriteLine($"You chose {arrowHead}, {fletching}, and {shaftLength}cm. The cost is {cost} gold.");
Console.WriteLine(arrow.ToString());

class Arrow
{
    public string arrowHead;
    public string fletching;
    public int shaftLength;

    public Arrow(string arrowHead, string fletching, int shaftLength)
    {
        this.arrowHead = arrowHead;
        this.fletching = fletching;
        this.shaftLength = shaftLength;
    }
    enum ArrowHeadType{Steel, Wood, Obsidian}
    enum FletchingType{Plastic, TurkeyFeathers, GooseFeathers}

    public decimal CalculateCost(string arrowHead, string fletching, int shaftLength)
    {
        decimal cost = 0;
        switch (arrowHead)
        {
            case "steel":
                cost += 10;
                break;
            case "wood":
                cost += 5;
                break;
            case "obsidian":
                cost += 3;
                break;
            default:
                break;
        }

        switch (fletching)
        {
            case "plastic":
                cost += 10;
                break;
            case "turkey feathers":
                cost += 5;
                break;
            case "goose feathers":
                cost += 3;
                break;
            default:
                break;
        }

        cost += shaftLength * .05m;
        return cost;
    }
}