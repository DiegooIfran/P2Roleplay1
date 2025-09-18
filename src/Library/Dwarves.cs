using System.Runtime.CompilerServices;

namespace Library;

public class Dwarves
{
    private string Name { get; }
    private List<item> Items = new List<item>();
    private int BaseHealth {get;}
    public int Health { set; get; }

    public Dwarves(string name, int baseHealth)
    {
        this.Name = name;
        this.Health = baseHealth;
        this.BaseHealth = baseHealth;
    }

    private void AddItem(item objeto)
    {
        Items.Add(objeto);
    }

    private void RemoveItem(item objeto)
    {
        Items.Remove(objeto);
    }

    private int GetAttack()
    {
        int attack = 0;
        foreach (item objeto in Items)
        {
            attack += objeto.Attack;
        }

        return attack;
    }
    
    public int GetDefense()
    {
        int defense = 0;
        foreach (item objeto in Items)
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
}
