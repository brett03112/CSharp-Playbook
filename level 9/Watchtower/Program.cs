/*
 * Create a program that lets you know where the enemy is 
 * relative to the watchtower using a grid system.
 */

int x = 0;
int y = 0;

Console.WriteLine("Enter an 'x' coordinate value:  ");
x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a 'y' coordinate value:  ");
y = int.Parse(Console.ReadLine());

if (x < 0 && y > 0)
    Console.WriteLine("The enemy is to the Northwest!!");
if (x < 0 && y == 0)
    Console.WriteLine("The enemy is to the West!!");
if (x < 0 && y < 0)
    Console.WriteLine("The enemy is to the Southwest!!");
if (x == 0 && y > 0)
    Console.WriteLine("The enemy is to the North!!");
if (x == 0 && y == 0)
    Console.WriteLine("Holy Shit!! The enemy is fucking our wives...");
if (x == 0 && y < 0)
    Console.WriteLine("The enemy is to the South!!");
if (x > 0 && y > 0)
    Console.WriteLine("The enemy is to the Northeast!!");
if (x > 0 && y == 0)
    Console.WriteLine("The enemy is to the East!!");
if (x > 0 && y < 0)
    Console.WriteLine("The enemy is to the Southeast!!");
