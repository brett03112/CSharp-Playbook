using System.Net.Security;

namespace TupleNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            (string, int, int) score = ("R2-D2", 12420, 15);
            Console.WriteLine(score);
            Console.WriteLine($"Name:{score.Item1} Level:{score.Item3} Score:{score.Item2}");

            //can also use the var keyword

            // var score = ("R2-D2", 12420, 15);

            (string, int, int) score1 = ("R2-D2", 12420, 15);
            (string, int, int) score2 = score1; // An exact match works.

            /*
             * Cannot do these!!
             * (string, int) partialScore = score1; // Not the same number of items.
             * (int, int, string) mixedUpScore = score1; // Items in a different order.
            */

            (string Name, int Points, int Level) score3 = ("R2-D2", 12420, 15);
            Console.WriteLine($"Name:{score3.Name} Level:{score3.Level} Score:{score3.Points}");

            Console.WriteLine();
            var score4 = (Name: "R2-D2", Points: 12420, Level: 15);
            Console.WriteLine($"Name:{score4.Name} Level:{score4.Level} Score:{score4.Points}");

            
            /*
                void DisplayScore((string Name, int Points, int Level) score)
                {
                    Console.WriteLine(
                    $"Name:{score.Name} Level:{score.Level} Score:{score.Points}");
                }
                var score5 = (Name: "Brett", Points: 288796, Level: 15);
                DisplayScore(score5);
            */

            Console.WriteLine();
            (string One, int Two, int Three) SScore = GetScore();
            DisplayScore(score);
            (string N, int P, int L) GetScore() => ("R2-D2", 12420, 15);
            void DisplayScore((string Name, int Points, int Level) score)
            {
                Console.WriteLine(
                $"Name:{score.Name} Level:{score.Level} Score:{score.Points}");
            }

            (double X, double Y) point = (2.0, 4.0);
            var tile = (Row: 2, Column: 4, Type: TileType.Grass);
            Console.WriteLine($"Row: {tile.Row}, Column: {tile.Column}, Type: {TileType.Grass}");
            Console.WriteLine();

            // And finally, let’s look at an example that creates and returns an array of (string, int,
            // int) tuples to create the full scoreboard we introduced at the beginning of this level:
            (string Name, int Points, int Level)[] CreateHighScores()
            {
                return new (string, int, int)[3]
                {
                    ("R2-D2", 12420, 15),
                    ("C-3PO", 8543, 9),
                    ("GONK", -1, 1),
                };
            }

        }
    }
    enum TileType { Grass, Water, Rock }
}