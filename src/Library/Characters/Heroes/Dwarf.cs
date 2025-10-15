using System.Runtime.CompilerServices;
using Library.Characters;

namespace Library;

// Creamos esta clase separada de Elf, Witch y Wizard para que
// pueda tener características específicas

// podemos extender Dwarf con nuevas habilidades sin modificar
// la lógica de otros personajes
public class Dwarf : Hero
{
   public Dwarf(string name, int health) : base(name, health)
    {
    }
}
