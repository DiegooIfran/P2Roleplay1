namespace Library;
public class Wizards
{
    private string Name { get; }
    private List<Item> Items = [];
    private SpellBook SpellBook = null;
    private int BaseHealth {get;}
    public int Health { set; get; }

    public Wizards(string name, int baseHealth)
    {
        this.Name = name;
        this.Health = baseHealth;
        this.BaseHealth = baseHealth;
    }

    private void AddItem(Item objeto)
    {
        Items.Add(objeto);
    }

    private void RemoveItem(Item objeto)
    {
        Items.Remove(objeto);
    }

    private int GetAttack()
    {
        int attack = 0;
        foreach (Item objeto in Items)
        {
            attack += objeto.Attack;
        }

        return attack;
    }
    
    public int GetDefense()
    {
        int defense = 0;
        foreach (Item objeto in Items)
        {
            defense += objeto.Defense;
        }

        return defense;
    }

    public int GetHealth()
    {
        return this.Health;
    }

    private void Heal()
    {
        this.Health = this.BaseHealth;
    }

    public void AttackElves(Elves target)
    {
        target.Health = target.Health - (this.GetAttack() - target.GetDefense());
    }
    
    public void AttackDwarves(Dwarves target)
    {
        target.Health = target.Health - (this.GetAttack() - target.GetDefense());
    }
    
    public void AttackWizards(Wizards target)
    {
        target.Health = target.Health - (this.GetAttack() - target.GetDefense());
    }
    
    private void AddSpellBook(SpellBook libro)
    {
        this.SpellBook= libro;
    }
}
