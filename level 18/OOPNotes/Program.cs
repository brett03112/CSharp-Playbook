/*
    Notes about OOP and classes in C#
*/

using System;

Score a = new Score("C-3PO", 10000, 10);


Score b = new Score("R2-D2", 12420, 15);



if (a.EarnedStar())
{
    Console.WriteLine("You earned a star!");
}

else{
    Console.WriteLine("No star was earned.");
}
class Score
{
    public string name;
    public int points;
    public int level;
    public Score(string name, int points, int level) 
    {
        this.name = name;
        this.level = level;
        this.points = points;
        
    }

    public bool EarnedStar() => (points / level) > 1000;
}