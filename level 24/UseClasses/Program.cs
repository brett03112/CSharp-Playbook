using level_24;
/*
*   This is where all the classes are created and derived from the base classes in there 
*   respective files.  I used the Point, Color, Card, PasswordValidatorand LockedDoor classes as
*   class library examples. UseClasses.csproj is the project file with the references.
*
*
*/
#region The Point class
//The Point class
Point a = new Point(2, 3);
Point b = new Point(-4,0);

string s = a.ToString();
string t = b.ToString();

WriteLine($"{s} {t}");
#endregion

#region The Color class
//The Color class
Color c = new Color(255, 0, 0);
Color d = Color.Cyan;

string u = c.ToString();
string v = d.ToString();

WriteLine(u);
WriteLine(v);
#endregion

#region The Card class
//The Card class

cardColor[] colors = new cardColor[] { cardColor.Red, cardColor.Green, cardColor.Blue, cardColor.Yellow };
Rank[] ranks= new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };

foreach (cardColor color in colors)
{
    foreach (Rank rank in ranks)
    {
        Card card = new Card(rank, color);
        Console.WriteLine($"The {card.Color} {card.Rank}");
    }
}
#endregion

#region The LockedDoor class

//The LockedDoor class
int initialPasscode = GetInt("What is the initial passcode?");
Door door = new Door(initialPasscode);
bool keepGoing = true;

while (keepGoing)
{
    Write($"The door is {door.State}. What do you want to do? (open, close, lock, unlock, change code) ");
    string? command = ReadLine();

    switch (command)
    {
        case "open":
            door.Open();
            break;
        case "close":
            door.Close();
            break;
        case "lock":
            door.Lock();
            break;
        case "unlock":
            int guess = GetInt("What is the passcode?");
            door.Unlock(guess);
            break;
        case "change code":
            int currentCode = GetInt("What is the current passcode?");
            int newCode = GetInt("What do you want to change it to?");
            door.ChangeCode(currentCode, newCode);
            break;
        default:
            WriteLine("I don't understand that command.  Goodbye.");
            keepGoing = false;
            break;
            
    }
}

int GetInt(string text)
{
    Write(text + " ");
    return Convert.ToInt32(ReadLine());
}

#endregion

#region The PasswordValidator class

//The PasswordValidator class
PasswordValidator validator = new PasswordValidator();

while (true)
{
    Write("Enter a password: ");
    string? password = ReadLine();

    if (password == null) return; // If the user enters a null password (Ctrl+Z) then let's be done.
                                 // An alternative could be to make `IsValid` handle null or to fall
                                 // back to some default string like the empty string ("") instead.
                                 // This challenge doesn't specifically call out dealing with null,
                                 // and it isn't easy to get a null in there in the first place. If
                                 // you ignored this possibility, that's fine too.

    if (validator.IsValid(password)) WriteLine("That password is valid.");
    else WriteLine("That password is not valid.");
}
#endregion