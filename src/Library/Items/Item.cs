namespace Library;

public class Item
{
    // Aplicamos el principio de encapsulamiento: propiedades con "private set",
    // para que solo puedan ser modificadas en el constructor
    public int Defense { get; private set; }
    public int Attack { get; private set; }
    public string Type { get; private set; }
    
    
    // Esto garantiza que todo Item creado tenga un estado válido desde el inicio
    public Item(int defense, int attack, string type)
    {
        Defense = defense;
        Attack = attack;
        Type = type;
    }
}
