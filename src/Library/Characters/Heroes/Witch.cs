using Library.Characters.Heroes;

namespace Library.Characters;

// La separamos en su propia clase para distinguirla de Wizard
// y permitir que tenga características diferentes en el futuro,
// como otro tipo de hechizos

// Implementa IMagicCharacter, lo que asegura que cumpla con el contrato
// de cualquier personaje mágico
public class Witch: Hero, IMagicCharacter
{
    private List<IMagicItem> _magicItems = new List<IMagicItem>();
   
    public Witch(string name, int health) : base(name, health)
    {
    }

    public override int GetAttack()
    {
        int attack = 0;
        foreach (IItem objeto in _items)
        {
            if (objeto is IAttackItem attackItem)
            {
                attack += attackItem.Attack;
            }
        }
        foreach (IMagicItem objeto in _magicItems)
        {
            if (objeto is IMagicAttackItem attackItem)
            {
                attack += attackItem.Attack;
            }
        }
        // Recorre los items que tiene el personaje sumando los daños de cada uno
        return attack;
    }
    
    public override int GetDefense()
    {
        int defense = 0;
        foreach (IItem objeto in _items)
        {
            if (objeto is IDefenseItem defenseItem)
            {
                defense += defenseItem.Defense;
            }
        }

        foreach (IMagicItem objeto in _magicItems)
            if (objeto is IMagicDefenceItem defenseItem)
            {
                defense += defenseItem.Defense;
            }
        // Recorre los items que tiene el personaje sumando las defensas de cada uno

        return defense;
    }
    public void AddMagicItem(IMagicItem magicItem)
    {
        this._magicItems.Add(magicItem);
    }

    public void RemoveMagicItem(IMagicItem magicItem)
    {
        this._magicItems.Remove(magicItem);
    }

    public List<IMagicItem> GetMagicItems()
    {
        return this._magicItems;
    }
}