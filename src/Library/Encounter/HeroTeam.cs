namespace Library.Encounter;
using Library.Characters.Heroes;
public class HeroTeam : ITeam<Hero>
{
    public string Name { get; }
    private List<Hero> _team { get; set; }

    public HeroTeam(string name)
    {
        this._team = new List<Hero>();
        this.Name = name;
    }

    public void AddToTeam(Hero character)
    {
        if (character.InTeam == false)
        {
            this._team.Add(character);    
            character.InTeam = true;
        }
        else
        {
            Console.WriteLine("Este heroe ya esta en un equipo");
        }
        
    }
    public void RemoveFromTeam(Hero character)
    {
        
        if (character.InTeam != false)
        {
            this._team.Remove(character);
            character.InTeam = false;
        }
        else
        {
            Console.WriteLine("Este heroe no esta en un equipo");
        }
    }

    public List<Hero> GetTeam()
    {
        return this._team;
    }
}