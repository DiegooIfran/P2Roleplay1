using Library;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.TestsEnemy;

public class TestGoblin
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void TestNameHealthAndVP()
    {
        // Testeo la creación de un Goblin y sus propiedades
        const string name = "Grub";
        const int health = 80;
        const int vp = 2;
        Goblin goblin = new Goblin(name, health, vp);
        Assert.That(goblin.Name, Is.EqualTo(name));
        Assert.That(goblin.Health, Is.EqualTo(health));
        Assert.That(goblin.VictoryPoints, Is.EqualTo(vp));
    }

    [Test]
    public void TestAttackHero()
    {
        // Testeo el ataque del Goblin a un Héroe
        Goblin goblin = new Goblin("Grub", 80, 2);
        Elf hero = new Elf("Legolas", 100);
        Sword sword = new Sword("Sword");
        goblin.AddItem(sword);
        goblin.Attack(hero);
        Assert.That(hero.Health, Is.LessThan(100));
    }
}