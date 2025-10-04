using Library;

namespace Ucu.Poo.RoleplayGame;

public class Helmet : IDefenseItem
{
    public int Defense
    {
        get
        {
            return 18;
        }
    }
    public string Name { get; set; }
    public Helmet(string name)
    {
        this.Name = name;
    }
}
