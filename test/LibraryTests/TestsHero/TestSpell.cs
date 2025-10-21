using Library;

namespace LibraryTests
{
    public class TestSpell
    {
        [Test]
        public void TestSpellStoresValues()
        {
            // Justificación: comprueba que el constructor de Spell guarda correctamente sus valores
            Spell spell = new Spell("Spell", 15);
            Assert.That(spell.Name, Is.EqualTo("Spell"));
            Assert.That(spell.Damage, Is.EqualTo(15));
        }

        [Test]
        public void TestGetDamage()
        {
            // Justificación: verifica que el método GetDamage devuelva el valor esperado
            Spell spell = new Spell("Spell", 20);
            Assert.That(spell.GetDamage(), Is.EqualTo(20));
        }
    }
}
