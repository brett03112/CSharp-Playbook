namespace Level24;

public class Card
{
    public Color Color {get;}
    public Rank Rank {get;}

    public Card(Color color, Rank rank)
    {
        Color = color;
        Rank = rank;
    }

    public bool IsSymbol => Rank == Rank.DollarSign || Rank == Rank.Percent || Rank == Rank.Caret || Rank == Rank.Ampersand;
    public bool IsNumber => !IsSymbol;
}


public enum Color { Red, Green, Blue, Yellow }
public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }
