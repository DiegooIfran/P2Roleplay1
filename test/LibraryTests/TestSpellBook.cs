using Library;

namespace LibraryTests
{
    public class TestSpellBook
    {
        [Test]
        public void TestAddAndRemoveSpells()
        {
            // Justificacion:valida que los hechizos se puedan agregar y eliminar del SpellBook
            Spell spell1 = new Spell("Spell", 15);
            Spell spell2 = new Spell("Spell", 5);
            SpellBook spellBook = new SpellBook();
        
            spellBook.AddSpell(spell1);
            spellBook.AddSpell(spell2);
        
            Assert.That(spellBook.Spells, Does.Contain(spell1));
            Assert.That(spellBook.Spells, Does.Contain(spell2));
        
            spellBook.RemoveSpell(spell1);
        
            Assert.That(spellBook.Spells, Does.Not.Contain(spell1));
            Assert.That(spellBook.Spells, Does.Contain(spell2));
        }
    }
}