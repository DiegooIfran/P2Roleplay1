using Library.Characters.Heroes;

namespace Library.Characters;

// A diferencia de otros personajes,
//Wizard implementa IMagicCharacter y contiene un SpellBook

// Usamos SpellBook como clase auxiliar para separar la responsabilidad
// de gestionar hechizos, manteniendo el principio SRP
// Esto también facilita la reutilización; otras clases mágicas como Witch
// pueden usar la misma lógica sin duplicar código
public class Wizard : Hero, IMagicCharacter
{
    private List<IMagicItem> _magicItems = new List<IMagicItem>();
    public Wizard(string name, int health) : base(name, health)
    {
    }
    public override int GetAttack()
    {
        int attack = 0;
        foreach (IItem objeto in Items)
        {
            if (objeto is IAttackItem attackItem)
            {
                attack += attackItem.Attack;
            }
        }
        foreach (IMagicItem objeto in _magicItems)
            if (objeto is IAttackItem attackItem)
            {
                attack += attackItem.Attack;
            }
        // Recorre los items que tiene el personaje sumando los daños de cada uno
        return attack;
    }

    public override int GetDefense()
    {
        int defense = 0;
        foreach (IItem objeto in Items)
        {
            if (objeto is IDefenseItem defenseItem)
            {
                defense += defenseItem.Defense;
            }
        }

        foreach (IMagicItem objeto in _magicItems)
            if (objeto is IDefenseItem defenseItem)
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
