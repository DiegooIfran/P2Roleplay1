using Library;
using Library.Characters;
using Ucu.Poo.RoleplayGame;

namespace Program;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Selecciona un tipo de personaje (elfo, enano, mago, bruja): ");
        string pj = Console.ReadLine();
        switch (pj)
        {
            case "elfo":
                Console.WriteLine($"Elegiste ser {pj}");
                Console.Write("Selecciona un nombre: ");
                string name = Console.ReadLine();
                Elf elfo = new Elf(name, 100);
                Console.WriteLine($"Eres {name}, un {pj}.");
                break;
            case "enano":
                Console.WriteLine($"Elegiste ser {pj}");
                Console.Write("Selecciona un nombre: ");
                name = Console.ReadLine();
                Dwarf enano = new Dwarf(name, 120);
                Console.WriteLine($"Eres {name}, un {pj}.");
                break;
            case "mago":
                Console.WriteLine($"Elegiste ser {pj}");
                Console.Write("Selecciona un nombre: ");
                name = Console.ReadLine();
                Wizard mago = new Wizard(name, 80);
                Console.WriteLine($"Eres {name}, un {pj}.");
                break;
            case "bruja":
                Console.WriteLine($"Elegiste ser {pj}");
                Console.Write("Selecciona un nombre: ");
                name = Console.ReadLine();
                Witch bruja = new Witch(name, 90);
                Console.WriteLine($"Eres {name}, un {pj}.");
                break;
            default:
                Console.WriteLine("No elegiste un personaje válido");
                break;
        }

        Dwarf gloin = new Dwarf("Glóin", 120);
        Witch brujaNocturna = new Witch("Bruja Nocturna", 90);
        Wizard magoHielo = new Wizard("Mago de Hielo", 80);
        Elf arwen = new Elf("Arwen", 180);

        Helmet helmet = new Helmet("Super Casco");
        gloin.AddItem(helmet);

        Staff staff = new Staff("Magic Staff");
        brujaNocturna.AddMagicItem(staff);
        
        brujaNocturna.Attack(gloin);
        
        Spell iceBall = new Spell("IceBall", 10);
        SpellBook spellBook = new SpellBook();
        spellBook.AddSpell(iceBall);
        magoHielo.AddSpellBook(spellBook);

        Bow arcoEncantado = new Bow("Arco Encantado");
        arwen.AddItem(arcoEncantado);
    }
}