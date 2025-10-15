namespace Library;
// La usamos para definir los métodos y propiedades mínimas
// que cualquier personaje debe tener
public abstract class Character
{
    public string Name { get; }
    public int Health { get; set; }
    public int BaseHealth { get; }
    protected List<IItem> _items = new List<IItem>();
    public bool InTeam { get; set; }

    protected Character(string name, int health)
    {
        this.Name = name;
        this.BaseHealth = health;
        this.Health = health;
        this._items = new List<IItem>();
        this.InTeam = false;
    }

    public virtual int GetAttack()
    {
        int attack = 0;
        foreach (IItem objeto in _items)
        {
            if (objeto is IAttackItem attackItem)
            {
                attack += attackItem.Attack;
            }
        }
        // Recorre los items que tiene el personaje sumando los daños de cada uno
        return attack;
    }
    
    public virtual int GetDefense()
    {
        int defense = 0;
        foreach (IItem objeto in _items)
        {
            if (objeto is IDefenseItem defenseItem)
            {
                defense += defenseItem.Defense;
            }
        }
        // Recorre los items que tiene el personaje sumando las defensas de cada uno
        
        return defense;
    }
    
    public List<IItem> GetItems()
    {
        return _items;
    }
    
    public int GetHealth() //Devuelve la vida actual
    {
        return Health;
    }
    
    public void Heal() //Cura al maximo
    {
        Health = BaseHealth;
    }
    
    public void AddItem(IItem item) //Añade un item
    {
        _items.Add(item);
    }

    public void RemoveItem(IItem item) //Quita un item
    {
        _items.Remove(item);
    }
}