namespace Library.Encounter;

public class EnemyTeam : ITeam<Enemy>
{
    public string Name { get; }
    private List<Enemy> _team { get; set; }

    public EnemyTeam(string name)
    {
        this.Name = name;
    }

    public void AddToTeam(Enemy character)
    {
        this._team.Add(character);
    }
    public void RemoveTeam(Enemy character)
    {
        this._team.Remove(character);
    }

    public List<Enemy> GetTeam()
    {
        return this._team;
    }
}