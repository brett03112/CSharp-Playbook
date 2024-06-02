namespace level_24;

public class Card
{
    public Rank Rank { get; }
    public cardColor Color { get; }

    public Card(Rank rank, cardColor color)
    {
        Rank = rank;
        Color = color;
    }

    public bool IsSymbol => Rank == Rank.Ampersand || Rank == Rank.Caret || Rank == Rank.DollarSign || Rank == Rank.Percent;
    public bool IsNumber => !IsSymbol;
}

public enum cardColor { Red, Blue, Green, Yellow }

public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }
