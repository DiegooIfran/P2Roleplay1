namespace Library.Encounter;
using Library.Characters;
public class EnemyTeam : ITeam<Enemy>
{
    public string Name { get; }
    private List<Enemy> _team { get; set; }

    public EnemyTeam(string name)
    {
        this._team = new List<Enemy>();
        this.Name = name;
    }

    public void AddToTeam(Enemy character)
    {
        if (character.InTeam == false)
        {
            this._team.Add(character);    
            character.InTeam = true;
        }
        else
        {
            Console.WriteLine("Este enemigo ya esta en un equipo");
        }
        
    }
    public void RemoveFromTeam(Enemy character)
    {
        
        if (character.InTeam != false)
        {
            this._team.Remove(character);    
            character.InTeam = false;
        }
        else
        {
            Console.WriteLine("Este enemigo no esta en un equipo");
        }
    }

    public List<Enemy> GetTeam()
    {
        return this._team;
    }
}