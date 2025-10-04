using Library;

namespace Ucu.Poo.RoleplayGame;

public class Sword : IAttackItem
{
    public int Attack
    {
        get
        {
            return 20;
        } 
    }
    public string Name { get; set; }
    public Sword(string name)
    {
        this.Name = name;
    }
}
