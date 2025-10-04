using Library;

namespace Ucu.Poo.RoleplayGame;

public class Shield : IDefenseItem
{
    public int Defense
    {
        get
        {
            return 10;
        }
    }    
    public string Name { get; set; }
    public Shield(string name)
    {
        this.Name = name;
    }
}
