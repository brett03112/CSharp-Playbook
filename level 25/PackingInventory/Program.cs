Pack pack = new Pack(10, 20, 30);

while (true)
{
    WriteLine($"Pack is currently at {pack.CurrentCount}/{pack.MaxCount} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, and {pack.CurrentVolume}/{pack.MaxVolume} volume.");

    WriteLine("What do you want to add?");
    WriteLine("1 - Arrow");
    WriteLine("2 - Bow");
    WriteLine("3 - Rope");
    WriteLine("4 - Water");
    WriteLine("5 - Food");
    WriteLine("6 - Sword");
    int choice = Convert.ToInt32(ReadLine());

    

    InventoryItem newItem = choice switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword(),
        _ => throw new NotImplementedException()
    };

    if (!pack.Add(newItem))
        WriteLine("Could not add this to the pack.");
    
    WriteLine($"The items in the pack are:");
    pack.DisplayItems();
}

public class Pack
{
    public int MaxCount { get; }
    public float MaxVolume { get; }
    public float MaxWeight { get; }

    private InventoryItem[] _items;
    
    public int CurrentCount { get; private set; }
    public float CurrentVolume { get; private set; }
    public float CurrentWeight { get; private set; }

    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        MaxCount = maxCount;
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;

        _items = new InventoryItem[maxCount];
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentCount >= MaxCount)
            return false;
        if (CurrentVolume + item.Volume > MaxVolume) 
            return false;
        if (CurrentWeight + item.Weight > MaxWeight) 
            return false;

        _items[CurrentCount] = item;
        CurrentCount++;
        CurrentVolume += item.Volume;
        CurrentWeight += item.Weight;
        return true;
    }

    public void DisplayItems()
    {
        for (int i = 0; i < CurrentCount; i++)
        {
            WriteLine($"{_items[i]}");
        }
    }
}

public class InventoryItem
{
    public float Weight { get; }
    public float Volume { get; }

    public InventoryItem(float weight, float volume)
    {
        Weight = weight;
        Volume = volume;
    }
}

public class Arrow : InventoryItem { public Arrow() : base(0.1f, 0.05f) { } }
public class Bow : InventoryItem { public Bow() : base(1, 4) { } }
public class Rope : InventoryItem { public Rope() : base(1, 1.5f) { } }
public class Water : InventoryItem { public Water() : base(2, 3) { } }
public class Food : InventoryItem { public Food() : base(1, 0.5f) { } }
public class Sword : InventoryItem { public Sword() : base(5, 3) { } }