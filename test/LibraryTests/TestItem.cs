using Library;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests
{
    public class TestItem
    {
        [Test]
        public void TestItemStoresValues()
        {
            // Justificación: verifica que el constructor de Item asigne bien sus propiedades
            Sword sword = new Sword("Sword");

            Assert.That(sword.Defense, Is.EqualTo(5));
            Assert.That(sword.Attack, Is.EqualTo(20));
            Assert.That(sword.Type, Is.EqualTo("Sword"));
        }
        
        [Test]
        public void TestMultipleItems()
        {
            // Justificación: verifico que se puedan crear distintos items de diferentes tipos
            Item sword = new Item(5, 10, "Sword");
            Item tunic = new Item(5, 0, "Tunic");
            Item shield = new Item(10, 0, "Shield");

            Assert.That(sword.Attack, Is.EqualTo(10));
            Assert.That(tunic.Defense, Is.EqualTo(5));
            Assert.That(shield.Defense, Is.EqualTo(10));

            Assert.That(sword.Type, Is.EqualTo("Sword"));
            Assert.That(tunic.Type, Is.EqualTo("Tunic"));
            Assert.That(shield.Type, Is.EqualTo("Shield"));
        }
    }
}