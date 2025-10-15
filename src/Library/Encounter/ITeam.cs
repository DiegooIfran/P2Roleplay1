namespace Library.Encounter;

public interface ITeam<T> where T : Character
{
    public string Name { get; }
    public void AddTeam();
    public void RemoveTeam();
}