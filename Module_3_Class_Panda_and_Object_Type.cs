// OBJECT TYPE (instance of the Panda class)
Panda p1 = new Panda("Linda");
Console.WriteLine("The first panda name is " + p1);   // Linda

// OBJECT TYPE
Panda p2 = new Panda ( Name = "Jack" );
Console.WriteLine("The second panda name is " + p2);   // Jack

public class Panda   // Class Type
{
    public string Name { get; set; }  

    
    public Panda() 

    public Panda(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }

}

