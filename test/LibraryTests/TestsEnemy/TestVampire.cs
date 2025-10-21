using Library;
using Library.Characters;
using Library.Characters.Heroes;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.TestsEnemy;

public class TestVampire
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void TestNameHealthAndVP()
    {
        const string name = "Dracula";
        const int health = 120;
        const int vp = 4;
        Vampire vampire = new Vampire(name, health, vp);
        Assert.That(vampire.Name, Is.EqualTo(name));
        Assert.That(vampire.Health, Is.EqualTo(health));
        Assert.That(vampire.VictoryPoints, Is.EqualTo(vp));
    }

    [Test]
    public void TestAttackHero()
    {
        Vampire vampire = new Vampire("Dracula", 120, 4);
        Hero hero = new Dwarf("Gimli", 100);
        Sword sword = new Sword("Sword");
        vampire.AddItem(sword);
        vampire.Attack(hero);
        Assert.That(hero.Health, Is.LessThan(100));
    }
}