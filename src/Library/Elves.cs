namespace Library;

public class Elves
{
    public string Name { get; set; }
    public List<Item> Items = new List<Item>();
    public int Health { get; set; }
    public int MaxHealth { get; set; }

    public Elves(string name, int health) //Constructor de elfo
    {
        Name = name;
        MaxHealth = health; //La variable MaxHealth se usara para restaurar la vida en otro momento
        Health = health;
        Items = new List<Item>();
    }

    public int GetAttack() //Devuelve el ataque total
    {
        int attack = 0;
        foreach (Item item in Items) // Recorre los items que tiene el personaje sumando los daños de cada uno
        {
            attack += item.Attack;
        }
        return attack;
    }
    
    public int GetDefense() //Devuelve la defensa total
    {
        int defense = 0;
        foreach (Item item in Items) // Recorre los items que tiene el personaje sumando las defensas de cada uno
        {
            defense += item.Defense;
        }
        return defense;
    }
    
    public int GetHealth() //Devuelve la vida actual
    {
        return Health;
    }
    
    public void Heal() //Cura al maximo
    {
        Health = MaxHealth;
    }
    
    public void AddItem(Item item) //Añade un item
    {
        Items.Add(item);
    }

    public void RemoveItem(Item item) //Quita un item
    {
        Items.Remove(item);
    }
    
    public void AttackElves(Elves elf) //Ataca a un elfo y le quita vida segun el ataque de elfo y la defensa del otro elfo
    {
        if ((GetAttack() - elf.GetDefense()) >= 0)
        {
            elf.Health = elf.Health - (GetAttack() - elf.GetDefense());
        }
    }
    
    public void AttackDwarves(Dwarves dwarf) //Ataca a un enano y le quita vida segun el ataque de elfo y la defensa del enano
    {
        if ((GetAttack() - dwarf.GetDefense()) >= 0)
        {
            dwarf.Health = dwarf.Health - (GetAttack() - dwarf.GetDefense());
        }
    }
    
    public void AttackWizards(Wizards wizard) //Ataca a un mago y le quita vida segun el ataque de elfo y la defensa del mago
    {
        if ((GetAttack() - wizard.GetDefense()) >= 0)
        {
            wizard.Health = wizard.Health - (GetAttack() - wizard.GetDefense());
        }
    }
}
