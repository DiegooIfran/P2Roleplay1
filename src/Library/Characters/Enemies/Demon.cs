namespace Library.Characters.Enemies;

public class Demon: Enemy, IMagicCharacter 
{
    private List<IMagicItem> _magicItems = new List<IMagicItem>()
    public Demon(string name, int health, int victoryPoints) : base(name, health, victoryPoints)
    {
    }

    public void AddMagicItem(IMagicItem magicItem)
    {
        this._magicItems.Add(magicItem);
    }

    public void RemoveMagicItem(IMagicItem magicItem)
    {
        this._magicItems.Remove(magicItem);
    }
}