/*
• Swords can be made out of any of the following materials: wood, bronze, iron, steel, and the rare binarium. Create an enumeration to represent the material type.

• Gemstones can be attached to a sword, which gives them strange powers through Cygnus and Lyra’s 
    touch. Gemstone types include emerald, amber, sapphire, diamond, and the rare bitstone. Or no
    gemstone at all. Create an enumeration to represent a gemstone type.

• Create a Sword record with a material, gemstone, length, and crossguard width.

• In your main program, create a basic Sword instance made out of iron and with no gemstone. Then create two variations on the basic sword using with expressions.

• Display all three sword instances with code like Console.WriteLine(original);.
*/

Sword basic = new Sword(SwordMaterial.Iron, Gemstone.None, 5, 1);
Sword better = basic with { Gemstone = Gemstone.Emerald };
Sword best = better with { Gemstone = Gemstone.Bitstone, Material = SwordMaterial.Steel, Length = 39, CrossguardWidth = 6 };

WriteLine(basic);
WriteLine(better);
WriteLine(best);
public record Sword(SwordMaterial Material, Gemstone Gemstone, float Length, float CrossguardWidth);

public enum SwordMaterial
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium
}

public enum Gemstone
{
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone,
    None
}