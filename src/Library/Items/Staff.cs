using Library;

namespace Ucu.Poo.RoleplayGame;

public class Staff : IMagicItem, IMagicDefenceItem, IMagicAttackItem
{
    public string Name { get; set; }
    public Staff(string name)
    {
        this.Name = name;
    }
    public int Attack
    {
        get
        {
            return 30;
        } 
    }
    public int Defense {
        get
        {
            return 10;
        } 
    }
}
