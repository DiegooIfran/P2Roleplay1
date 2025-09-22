namespace Library;

public class Elves
{
    public string Name { get; set; }
    public List<Item> Items = new List<Item>();
    public int Health { get; set; }
    public int MaxHealth { get; set; }

    public Elves(string name, int health)
    {
        Name = name;
        MaxHealth = health;
        Health = health;
        Items = new List<Item>();
    }

    public int GetAttack()
    {
        int attack = 0;
        foreach (Item item in Items)
        {
            attack += item.Attack;
        }
        return attack;
    }
    
    public int GetDefense()
    {
        int defense = 0;
        foreach (Item item in Items)
        {
            defense += item.Defense;
        }
        return defense;
    }
    
    public int GetHealth()
    {
        return Health;
    }
    
    public void Heal()
    {
        Health = MaxHealth;
    }
    
    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }
    
    public void AttackElves(Elves elf)
    {
        if ((GetAttack() - elf.GetDefense()) >= 0)
        {
            elf.Health = elf.Health - (GetAttack() - elf.GetDefense());
        }
    }
    
    public void AttackDwarves(Dwarves dwarf)
    {
        if ((GetAttack() - dwarf.GetDefense()) >= 0)
        {
            dwarf.Health = dwarf.Health - (GetAttack() - dwarf.GetDefense());
        }
    }
    
    public void AttackWizards(Wizards wizard)
    {
        if ((GetAttack() - wizard.GetDefense()) >= 0)
        {
            wizard.Health = wizard.Health - (GetAttack() - wizard.GetDefense());
        }
    }
}
