namespace Library.Characters.Enemies;

public class Skeleton: Enemy
{
    private string _name;
    public int Health;
    public Skeleton(string name, int health, int vp) : base(name, health, vp)
    { }
}