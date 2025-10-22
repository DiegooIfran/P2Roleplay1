using Library;

namespace LibraryTests
{
    public class TestSpell
    {
        [Test]
        public void TestSpellStoresValues()
        {
            // Justificaci�n: comprueba que el constructor de Spell guarda correctamente sus valores
            Spell spell = new Spell("Spell", 15);
            Assert.That(spell.Name, Is.EqualTo("Spell"));
            Assert.That(spell.GetPower(), Is.EqualTo(15));
        }

        [Test]
        public void TestGetDamage()
        {
            // Justificaci�n: verifica que el m�todo GetDamage devuelva el valor esperado
            Spell spell = new Spell("Spell", 20);
            Assert.That(spell.GetPower(), Is.EqualTo(20));
        }
    }
}
