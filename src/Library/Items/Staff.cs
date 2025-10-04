using Library;

namespace Ucu.Poo.RoleplayGame;

public class Staff : IMagicItem
{
    public int Attack
    {
        get
        {
            return 100;
        } 
    }
    public string Name { get; set; }
    public Staff(string name)
    {
        this.Name = name;
    }

    public int DefenseValue
    {
        get
        {
            return 100;
        }
    }
}
