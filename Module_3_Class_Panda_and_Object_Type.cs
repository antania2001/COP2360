// OBJECT TYPE (instance of the Panda class)
Panda p1 = new Panda("Linda");
Console.WriteLine("The first panda name is " + p1);   // Linda

// OBJECT TYPE using object initializer
Panda p2 = new Panda { Name = "Jack" };
Console.WriteLine("The second panda name is " + p2);   // Jack

public class Panda   // CLASS TYPE
{
    public string Name { get; set; }   // Simple property to hold the name of the panda

    // Optional constructor
    public Panda() { }

    public Panda(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}