namespace Library;

public interface ICharacter
{
    string Name { get; }  
    IReadOnlyList<Item> Items { get; } 
    int Health { get; set; }
    int BaseHealth { get; }

    void AddItem(IItem item);
    void RemoveItem(IItem item);
    int GetAttack();
    int GetDefense();
    int GetHeal();
    void Heal();
    void Attack(ICharacter target);
}