namespace Library;

public class SpellBook
{
    public List<Spell> Spells { get; private set; }

    public SpellBook()
    {
        Spells = new List<Spell>();
    }

    public void AddSpell(Spell spell)
    {
        if (!Spells.Contains(spell))
        {
            Spells.Add(spell);
        }
    }

    public void RemoveSpell(Spell spell)
    {
        if (Spells.Contains(spell))
        {
            Spells.Remove(spell);
        }
    }
}
