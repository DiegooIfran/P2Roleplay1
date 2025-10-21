using Library.Characters;
using Library.Characters.Enemies;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests.TestsEnemy;

public class TestSkeleton
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void TestNameHealthAndVP()
    {
        const string name = "Bones";
        const int health = 60;
        const int vp = 3;
        Skeleton skeleton = new Skeleton(name, health, vp);
        Assert.That(skeleton.Name, Is.EqualTo(name));
        Assert.That(skeleton.Health, Is.EqualTo(health));
        Assert.That(skeleton.VictoryPoints, Is.EqualTo(vp));
    }

    [Test]
    public void TestAttackHero()
    {
        Skeleton skeleton = new Skeleton("Bones", 60, 3);
        Wizard hero = new Wizard("Gandalf", 100);
        Sword boneSword = new Sword("Bone Sword");
        skeleton.AddItem(boneSword);
        skeleton.Attack(hero);
        Assert.That(hero.Health, Is.LessThan(100));
    }
}