namespace Library.Characters.Enemies;

public class Skeleton
{
    public Skeleton(string name, int health, int vp) //Constructor de Skeleton
    {
        Name = name;
        BaseHealth = health; //La variable MaxHealth se usara para restaurar la vida en otro momento
        Health = health;
        Vp = vp;
        InTeam = false;
    }
}