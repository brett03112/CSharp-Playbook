Console.WriteLine("This chapter focuses on Switch statements.");

Console.WriteLine("Avast, matey! What be ye desire?\r\n1 – Rest\r\n2 – Pillage the port\r\n3 – Set sail\r\n4 – Release the Kraken\r\nWhat be the plan, Captain?");

int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Ye rest and recover your health.");
        break;
    case 2:
        Console.WriteLine("Raiding the port town get ye 50 gold doubloons.");
        break;
    case 3:
        Console.WriteLine("The wind is at your back; the open horizon ahead.");
        break;
    case 4:
        Console.WriteLine("'Tis but a baby Kraken, but still eats toy boats.");
        break;
    default:
        Console.WriteLine("Apologies. I do not know that one.");
        break;
}

// A Switch expression is easier to do.
string response;
response = choice switch
{
    1 => "Ye rest and recover your health.",
    2 => "Raiding the port town get ye 50 gold doubloons.",
    3 => "The wind is at your back; the open horizon ahead.",
    4 => "'Tis but a baby Kraken, but still eats toy boats.",
    _ => "Apologies. I do not know that one."
};
Console.WriteLine(response);

Console.WriteLine("The following items are available:\r\n1 – Rope\r\n2 – Torches\r\n3 – Climbing Equipment\r\n4 – Clean Water\r\n5 – Machete\r\n6 – Canoe\r\n7 – Food Supplies\r\nWhat number do you want to see the price of?");