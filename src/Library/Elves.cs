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
    
    private void Heal()
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
    
    public void GetDamaged(int damage)
    {
        Health -= damage;
    }
    
    public void AttackElves(Elves elf)
    {
        int attack = GetAttack();
        elf.GetDamaged(attack);
    }
    
    public void AttackDwarves(Dwarves dwarf)
    {
        int attack = GetAttack();
        dwarf.GetDamaged(attack);
    }
    
    public void AttackWizards(Wizards wizard)
    {
        int attack = GetAttack();
        wizard.GetDamaged(attack);
    }
}
