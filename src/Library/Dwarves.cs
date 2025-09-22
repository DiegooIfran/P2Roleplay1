using System.Runtime.CompilerServices;

namespace Library;

public class Dwarves
{
    public string Name { get; }
    private List<Item> Items = new List<Item>();
    public int BaseHealth {get;}
    public int Health { set; get; }

    public Dwarves(string name, int baseHealth)
    {
        this.Name = name;
        this.Health = baseHealth;
        this.BaseHealth = baseHealth;
        //La variable BaseHealth se usara para restaurar la vida en otro momento
    }
    

    public void AddItem(Item objeto)
    {
        Items.Add(objeto);
    }

    public void RemoveItem(Item objeto)
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
        // Recorre los items que tiene el personaje sumando los daños de cada uno
        return attack;
    }
    
    public int GetDefense()
    {
        int defense = 0;
        foreach (Item objeto in Items)
        {
            defense += objeto.Defense;
        }
        // Recorre los items que tiene el personaje sumando las defensas de cada uno

        return defense;
    }

    public List<Item> GetItems()
    {
        return Items;
    }
    public int GetHealth()
    {
        return this.Health;
    }

    public void Heal()
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
}
