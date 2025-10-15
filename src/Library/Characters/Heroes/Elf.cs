using Library.Characters.Heroes;

namespace Library;

// Creamos esta clase separada porque cada tipo de personaje
// puede tener comportamientos únicos en el futuro
// De esta manera, aplicamos el Principio de Responsabilidad Única (SRP)
// y el código queda preparado para extenderse sin romper a los demás personajes
public class Elf : Hero
{
    public Elf(string name, int health) : base(name,health)
    {
    }
}
