using Library.Characters;

namespace Library;

// Creamos esta clase separada porque cada tipo de personaje
// puede tener comportamientos únicos en el futuro
// De esta manera, aplicamos el Principio de Responsabilidad Única (SRP)
// y el código queda preparado para extenderse sin romper a los demás personajes
public class Goblin: Enemy
{
    public Goblin(string name, int health, int vp) //Constructor de goblin
    {
        Name = name;
        BaseHealth = health; //La variable MaxHealth se usara para restaurar la vida en otro momento
        Health = health;
        Vp = vp;
        InTeam = false;
    }

}
