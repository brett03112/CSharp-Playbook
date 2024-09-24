using ColoredItem;


ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Red);
ColoredItem<Bow> bow = new ColoredItem<Bow>(new Bow(), ConsoleColor.Blue);
ColoredItem<Wand> wand = new ColoredItem<Wand>(new Wand(), ConsoleColor.Green);

sword.Display();
bow.Display();
wand.Display();