namespace Library;
// La usamos para definir los métodos y propiedades mínimas
// que cualquier personaje debe tener
public interface ICharacter
{
    string Name { get; }
    int Health { get; set; }
    int BaseHealth { get; }
    
    List<IItem> GetItems();
    void AddItem(IItem item);
    void RemoveItem(IItem item);
    int GetAttack();
    int GetDefense();
    int GetHealth();
    void Heal();
    void Attack(ICharacter target);
}