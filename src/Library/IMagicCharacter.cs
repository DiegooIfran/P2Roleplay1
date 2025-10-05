namespace Library;

public interface IMagicCharacter:ICharacter
{
    void AddMagicItem(IMagicItem magicItem);
    void RemoveMagicItem(IMagicItem magicItem);
}