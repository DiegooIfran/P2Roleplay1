using Library;

namespace Ucu.Poo.RoleplayGame;

public class Bow : IAttackItem
{
    public int Attack
    {
        get
        {
            return 10;
        } 
    }
    public string Name { get; set; }
    public Bow(string name)
    {
        this.Name = name;
    }
}
