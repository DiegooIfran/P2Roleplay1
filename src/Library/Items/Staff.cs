using Library;

namespace Ucu.Poo.RoleplayGame;

public class Staff : IMagicItem, IAttackItem, IDefenseItem
{
    public int Attack
    {
        get
        {
            return 60;
        } 
    }
    public string Name { get; set; }
    public Staff(string name)
    {
        this.Name = name;
    }

    public int Defense
    {
        get
        {
            return 20;
        }
    }
}
