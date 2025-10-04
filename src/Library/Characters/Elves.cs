namespace Library;

public class Elves : ICharacter
{
    public string Name { get; set; }
    private List<IItem> _items = new List<IItem>();
    public int Health { get; set; }
    public int BaseHealth { get; set; }

    public Elves(string name, int health) //Constructor de elfo
    {
        Name = name;
        BaseHealth = health; //La variable MaxHealth se usara para restaurar la vida en otro momento
        Health = health;
    }

    public int GetAttack()
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
    
    public int GetDefense()
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
    
    public void Attack(ICharacter target) //Ataca y le quita vida segun la defensa del objetivo y el ataque del elfo
    {
        if ((this.GetAttack() - target.GetDefense()) >= 0) //Para checkear que el daño sea un numero positivo
        {
            target.Health = target.Health - (this.GetAttack() - target.GetDefense());
        }
    }
}
