namespace Library;
// Cada SpellBook se encarga solo de administrar sus hechizos (SRP)
public class SpellBook:IMagicItem
{
    public List<Spell> Spells { get; private set; }
    public string Name { get; set; }
    // Constructor: inicializa la lista vacía para que el SpellBook siempre tenga un estado válido
    public SpellBook()
    {
        Spells = new List<Spell>();
    }

    // Método para agregar un hechizo, evitando duplicados
    public void AddSpell(Spell spell)
    {
        if (!Spells.Contains(spell))
        {
            Spells.Add(spell);
        }
    }
    
    // Método para remover un hechizo si está en el libro
    // Protege la integridad de la lista antes de eliminar elementos
    public void RemoveSpell(Spell spell)
    {
        if (Spells.Contains(spell))
        {
            Spells.Remove(spell);
        }
    }
}
