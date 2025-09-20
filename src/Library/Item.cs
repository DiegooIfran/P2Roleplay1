namespace Library;

public class Item
{
    public int Defense { get; private set; }
    public int Attack { get; private set; }
    public string Type { get; private set; }

    public Item(int defense, int attack, string type)
    {
        Defense = defense;
        Attack = attack;
        Type = type;
    }
}
