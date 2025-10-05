using Library;
using Library.Characters;

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
                Elves elfo = new Elves(name, 100);
                Console.WriteLine($"Eres {name}, un {pj}.");
                break;
            case "enano":
                Console.WriteLine($"Elegiste ser {pj}");
                Console.Write("Selecciona un nombre: ");
                name = Console.ReadLine();
                Dwarves enano = new Dwarves(name, 120);
                Console.WriteLine($"Eres {name}, un {pj}.");
                break;
            case "mago":
                Console.WriteLine($"Elegiste ser {pj}");
                Console.Write("Selecciona un nombre: ");
                name = Console.ReadLine();
                Wizards mago = new Wizards(name, 80);
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

        Dwarves gloin = new Dwarves("Glóin", 120);
        Witch brujaNocturna = new Witch("Bruja Nocturna", 90);
    }
}