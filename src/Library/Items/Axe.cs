using Library;

namespace Ucu.Poo.RoleplayGame;

public class Axe : IAttackItem
{
    public int Attack
    {
        get
        {
            return 15;
        } 
    }
    public string Name { get; set; }
    public Axe(string name)
    {
        this.Name = name;
    }
}
