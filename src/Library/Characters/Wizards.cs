namespace Library;
public class Wizards : IMagicCharacter
{
    public string Name { get; }
    private List<IItem> _items = new List<IItem>();
    public SpellBook SpellBook;
    public int BaseHealth {get;}
    public int Health { set; get; }

    public Wizards(string name, int baseHealth)
    {
        this.Name = name;
        this.Health = baseHealth;
        this.BaseHealth = baseHealth;
    }

    public void AddItem(IItem objeto)
    {
        _items.Add(objeto);
    }

    public void RemoveItem(IItem objeto)
    {
        _items.Remove(objeto);
    }
    public List<IItem> GetItems()
    {
        return _items;
    }
    private int GetAttack()
    {
        int attack = 0;
        foreach (IItem objeto in _items)
        {
            attack += objeto.Attack;
        }

        return attack;
    }
    
    public int GetDefense()
    {
        int defense = 0;
        foreach (IItem objeto in _items)
        {
            defense += objeto.Defense;
        }

        return defense;
    }

    public int GetHealth()
    {
        return this.Health;
    }

    public void Heal()
    {
        this.Health = this.BaseHealth;
    }

    public void Attack(ICharacter target) //Ataca y le quita vida segun la defensa del objetivo y el ataque del mago
    {
        if ((this.GetAttack() - target.GetDefense()) >= 0) //Para checkear que el daño sea un numero positivo
        {
            target.Health = target.Health - (this.GetAttack() - target.GetDefense());
        }
    }

    public void AddSpellBook(SpellBook libro)
    {
        this.SpellBook= libro;
    }
}
