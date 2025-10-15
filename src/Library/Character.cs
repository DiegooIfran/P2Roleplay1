namespace Library;
// La usamos para definir los métodos y propiedades mínimas
// que cualquier personaje debe tener
public abstract class Character
{
    public string Name { get; }
    public int Health { get; set; }
    public int BaseHealth { get; }
    private List<IItem> Items = new List<IItem>();
    public bool InTeam { get; set; }

    public Character(string name, int health)
    {
        this.Name = name;
        this.BaseHealth = health;
        this.Health = health;
        this.Items = new List<IItem>();
        this.InTeam = false;
    }
    
    public virtual int GetAttack()
    {
        int attack = 0;
        foreach (IItem objeto in Items)
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
        foreach (IItem objeto in Items)
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
        return Items;
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
        Items.Add(item);
    }

    public void RemoveItem(IItem item) //Quita un item
    {
        Items.Remove(item);
    }
}