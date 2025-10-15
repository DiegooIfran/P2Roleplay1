namespace Library.Characters;

public abstract class Hero : Character
{
    public int VictoryPoints { get; set; }
    
    public void Attack(Enemy target) //Ataca y le quita vida segun la defensa del objetivo y el ataque del heroe
    {
        if ((this.GetAttack() - target.GetDefense()) >= 0) //Para checkear que el daño sea un numero positivo
        {
            target.Health = target.Health - (this.GetAttack() - target.GetDefense());
        }
    }

    protected Hero(string name, int health) : base(name, health)
    {
        VictoryPoints = 0;
    }
}
