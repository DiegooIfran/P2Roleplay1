using Library;
using Library.Characters;
using Library.Characters.Enemies;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestWitch
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestNameAndHealth()
    {
        // En este testeo creo un objeto Witch testeando el nombre y la vida
        string name = "Bruja Escarlata";
        int health = 140;
        Witch witch = new Witch(name, health);
        Assert.That(witch.Name, Is.EqualTo(name));
        Assert.That(witch.Health, Is.EqualTo(health));
        Assert.That(witch.BaseHealth, Is.EqualTo(health));
    }

    [Test]
    public void TestItems()
    {
        // Testeo los métodos para agregar y quitar ítems
        string name = "Bruja Escarlata";
        int health = 140;
        Witch witch = new Witch(name, health);
        Staff itemAtt = new Staff("Bastón mágico");
        Armor itemDef = new Armor("Túnica encantada");
        witch.AddMagicItem(itemAtt);
        witch.AddItem(itemDef);
        Assert.That(witch.GetMagicItems(), Does.Contain(itemAtt));
        Assert.That(witch.GetItems(), Does.Contain(itemDef));
        witch.RemoveMagicItem(itemAtt);
        witch.RemoveItem(itemDef);
        Assert.That(witch.GetMagicItems(), Is.Empty);
        Assert.That(witch.GetItems(), Is.Empty);
    }

    [Test]
    public void TestAttack()
    {
        // Testeo el método para atacar a un malo
        Witch witch = new Witch("Bruja Escarlata", 140);
        Staff itemAtt = new Staff("Bastón mágico");
        Helmet itemDef = new Helmet("Yelmo rúnico");
        witch.AddMagicItem(itemAtt);
        witch.AddItem(itemDef);
        Skeleton skeleton = new Skeleton("Pepe", 70, 3);
        witch.Attack(skeleton);
        Assert.That(skeleton.GetHealth(), Is.Not.EqualTo(70));
    }

    [Test]
    public void Heal()
    {
        // Testeo recibir daño y curarse correctamente
        Witch witch = new Witch("Bruja Escarlata", 140);
        Skeleton skeleton = new Skeleton("Pepe", 70, 3);
        Axe itemAtt = new Axe("Hacha de guerra");
        skeleton.AddItem(itemAtt);
        skeleton.Attack(witch);
        Assert.That(witch.GetHealth(), Is.LessThan(140)); // Recibió daño
        witch.Heal();
        Assert.That(witch.GetHealth(), Is.EqualTo(140)); // Se cura completamente
    }

    [Test]
    public void SpellBook()
    {
        // Testeo que las brujas solo puedan tener un SpellBook
        string name = "Bruja Escarlata";
        int health = 140;
        Witch witch = new Witch(name, health);

        Spell fireBall = new Spell("FireBall", 15);
        SpellBook spellBook1 = new SpellBook();
        spellBook1.AddSpell(fireBall);
        witch.AddMagicItem(spellBook1);

        Assert.That(witch.GetMagicItems()[0], Is.EqualTo(spellBook1));
    }
}
