// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");

//This is what we are talking about
string a = Console.ReadLine();

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

//b stores how you describe the thing
string b = Console.ReadLine();

//this adds the 'of Doom' modifier
string c = "of Doom";

//adds the model number
string d = "3000";

/*The final statement puts everything together with
 * concatentation */
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");