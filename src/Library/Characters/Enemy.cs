using Library.Characters.Heroes;

namespace Library.Characters;

public abstract class Enemy : Character
{
    public int VictoryPoints { get; set; }
    
    public void Attack(Hero target) //Ataca y le quita vida segun la defensa del objetivo y el ataque del enemigo
    {
        if ((this.GetAttack() - target.GetDefense()) >= 0) //Para checkear que el daño sea un numero positivo
        {
            target.Health = target.Health - (this.GetAttack() - target.GetDefense());
        }
    }

    protected Enemy(string name, int health) : base(name, health)
    {
        VictoryPoints = VictoryPoints;
    }
}
