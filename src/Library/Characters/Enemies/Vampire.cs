namespace Library.Characters;

public class Vampire
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Vampire(string name, int health) //Constructor de vampiro
    {
        Name = name;
        Health = health;
    }
}
