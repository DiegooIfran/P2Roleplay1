namespace Library.Encounter;

public class HeroTeam : ITeam<Hero>
{
    public string Name { get; }
    private List<Hero> _team { get; set; }

    public HeroTeam(string name)
    {
        this.Name = name;
    }

    public void AddToTeam(Hero character)
    {
        this._team.Add(character);
    }
    public void RemoveFromTeam(Hero character)
    {
        this._team.Remove(character);
    }

    public List<Hero> GetTeam()
    {
        return this._team;
    }
}