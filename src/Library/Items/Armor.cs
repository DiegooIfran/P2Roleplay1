using Library;

namespace Ucu.Poo.RoleplayGame;

public class Armor : IDefenseItem
{
    public string Name { get; set; }
    public int Defense
    {
        get
        {
            return 15;
        }
    }

    public Armor(string name)
    {
        this.Name = name;
    }
}
