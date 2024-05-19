/*
    Modify the Arrow program so that the Arrow class uses properties instead of GetX and SetX methods

*/


WriteLine("Each arrow has 3 parts: the arrowhead (steel, wood, or obsidian), the shaft (a length between 60 and 100 cm long), " +
            "and the fletching (plastic, turkey feathers, goose feathers).");
WriteLine("Enter the arrowhead type:");
string? arrowHead = ReadLine();
arrowHead = arrowHead!.ToLower();

WriteLine("Enter the fletching type:");
string? fletching = ReadLine();
fletching = fletching!.ToLower();

WriteLine("Enter the shaft length:");
int shaftLength = Convert.ToInt32(ReadLine());

Arrow arrow = new Arrow(arrowHead, fletching, shaftLength);
decimal cost = arrow.CalculateCost(arrowHead, fletching, shaftLength);

WriteLine($"You chose {arrowHead}, {fletching}, and {shaftLength} cm. The cost is {cost:C} gold."); // Use :C to format the cost

//show the default values of the Arrow class
Arrow arrow1 = new Arrow();
WriteLine($"The default values of the Arrow class are: {arrow1.arrowHead}, {arrow1.fletching}, and {arrow1.shaftLength} cm.");







class Arrow
{
    // make fields private
    private string? _arrowHead;
    private string? _fletching;
    private int _shaftLength;

    public string? arrowHead{get; set;} = "Wood"; // default value
    public string? fletching{get; set;} = "Plastic"; // default value
    public int shaftLength{get; set;} = 45; // default value 

    // default constructor
    public Arrow(){ }

    // Constructor with entered parameters
    public Arrow(string arrowHead, string fletching, int shaftLength)
    {
        _arrowHead = arrowHead;
        _fletching = fletching;
        _shaftLength = shaftLength;
    }
    enum ArrowHeadType{Steel, Wood, Obsidian}
    enum FletchingType{Plastic, TurkeyFeathers, GooseFeathers}

   

    // the only class method available
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