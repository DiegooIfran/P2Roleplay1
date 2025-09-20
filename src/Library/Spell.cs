namespace Library;

public class Spell
{
    public string Name { get; private set; }
    public int Damage { get; private set; }

    public Spell(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public int GetDamage()
    {
        return Damage;
    }
}
