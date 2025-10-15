namespace Library;

// Lo definimos como clase propia porque encapsula la información
// y la lógica de un hechizo

// Esta decisión permite reutilizar los hechizos en distintos SpellBooks
// sin duplicar datos
public class Spell
{ 
    // Usamos propiedades inmutables (private set) para proteger la información del hechizo
    // Esto sigue el principio de encapsulamiento
    public string Name { get; private set; }
    private int Power { get; set; }

    public Spell(string name, int damage)
    {
        Name = name;
        Power = damage;
    } 
    
    // Creamos un método para obtener el daño en lugar de acceder directamente a la propiedad, para que otras
    // partes del programa no dependan de cómo se calcula internamente el daño.
    // Esto permite cambiar la lógica en el futuro sin afectar al resto del juego
    public int GetPower()
    {
        return Power;
    }
}
