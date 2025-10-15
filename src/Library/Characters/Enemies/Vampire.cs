namespace Library.Characters;

public class Vampire : Enemy
{
    public Vampire(string name, int health) : base(name, health)
    {
        Name = name;
        Health = health;
    }

    public string Name { get; set; }
    public int Health { get; set; }

  
}

