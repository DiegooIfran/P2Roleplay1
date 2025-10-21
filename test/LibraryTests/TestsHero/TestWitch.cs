using Library;
using Library.Characters;
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
    public void TestAttackDwarf()
    {
        // Testeo el método para atacar a un enano
        Witch witch = new Witch("Bruja Escarlata", 140);
        Staff itemAtt = new Staff("Bastón mágico");
        Helmet itemDef = new Helmet("Yelmo rúnico");
        witch.AddMagicItem(itemAtt);
        witch.AddItem(itemDef);
        Dwarf dwarfTarget = new Dwarf("Gruñón", 120);
        witch.Attack(dwarfTarget);
        Assert.That(dwarfTarget.GetHealth(), Is.Not.EqualTo(120));
    }

    [Test]
    public void TestAttackElf()
    {
        // Testeo el método para atacar a un elfo
        Witch witch = new Witch("Bruja Escarlata", 140);
        Staff itemAtt = new Staff("Bastón mágico");
        Helmet itemDef = new Helmet("Yelmo rúnico");
        witch.AddMagicItem(itemAtt);
        witch.AddItem(itemDef);
        Elf elfTarget = new Elf("Legolas", 100);
        witch.Attack(elfTarget);
        Assert.That(elfTarget.GetHealth(), Is.Not.EqualTo(100));
    }

    [Test]
    public void TestAttackWitch()
    {
        // Testeo el método para atacar a otra bruja
        Witch witch1 = new Witch("Bruja Escarlata", 140);
        Axe itemAtt = new Axe("Hacha demoníaca");
        Helmet itemDef = new Helmet("Yelmo oscuro");
        witch1.AddItem(itemAtt);
        witch1.AddItem(itemDef);
        Witch witch2 = new Witch("Morgana", 100);
        witch1.Attack(witch2);
        Assert.That(witch2.GetHealth(), Is.Not.EqualTo(100));
    }

    [Test]
    public void Heal()
    {
        // Testeo recibir daño y curarse correctamente
        Witch witch = new Witch("Bruja Escarlata", 140);
        Dwarf dwarf = new Dwarf("Gruñón", 100);
        Axe itemAtt = new Axe("Hacha de guerra");
        dwarf.AddItem(itemAtt);
        dwarf.Attack(witch);
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
        witch.AddSpellBook(spellBook1);

        Assert.That(witch.SpellBook, Is.EqualTo(spellBook1));

        Spell iceBall = new Spell("IceBall", 10);
        SpellBook spellBook2 = new SpellBook();
        spellBook2.AddSpell(fireBall);
        spellBook2.AddSpell(iceBall);
        witch.AddSpellBook(spellBook2);

        Assert.That(witch.SpellBook, Is.EqualTo(spellBook2));
        Assert.That(witch.SpellBook, Is.Not.EqualTo(spellBook1));
    }
}
