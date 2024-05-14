/*
 * @author: Brett Smith
 * Date: 5/14/2024
 * Update the arrow class to hide access modifiers
 */

WriteLine("Each arrow has 3 parts: the arrowhead (steel, wood, or obsidian), the shaft (a length between 60 and 100 cm long), " +
            "and the fletching (plastic, turkey feathers, goose feathers).");
WriteLine("Enter the arrowhead type:");
string? arrowHead = ReadLine();
arrowHead = arrowHead.ToLower();

WriteLine("Enter the fletching type:");
string? fletching = ReadLine();
fletching = fletching.ToLower();

WriteLine("Enter the shaft length:");
int shaftLength = Convert.ToInt32(ReadLine());

Arrow arrow = new Arrow(arrowHead, fletching, shaftLength);
decimal cost = arrow.CalculateCost(arrowHead, fletching, shaftLength);

WriteLine($"You chose {arrowHead}, {fletching}, and {shaftLength}cm. The cost is {cost:C} gold."); // Use :C to format the cost







class Arrow
{
    // make fields private
    private string _arrowHead;
    private string _fletching;
    private int _shaftLength;

    // Keep the contructor public and set the fields with the parameters
    public Arrow(string arrowHead, string fletching, int shaftLength)
    {
        _arrowHead = arrowHead;
        _fletching = fletching;
        _shaftLength = shaftLength;
    }
    enum ArrowHeadType{Steel, Wood, Obsidian}
    enum FletchingType{Plastic, TurkeyFeathers, GooseFeathers}

    // get methods
    public string GetArrowHead() => _arrowHead;
    public string GetFletching() => _fletching;
    public int GetShaftLength() => _shaftLength;

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

    // set methods
    public void SetArrowHead(string value) => _arrowHead = value;
    public void SetFletching(string value) => _fletching = value;
    public void SetShaftLength(int value) => _shaftLength = value;
}