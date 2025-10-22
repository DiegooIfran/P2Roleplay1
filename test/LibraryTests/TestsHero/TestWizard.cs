using Library;
using Library.Characters;
using Library.Characters.Enemies;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestWizard
{
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestNameAndHealth()
    {
        // En este testeo creo un objeto Dwarves testeando los nombres y la vida
        string name = "Mago Eléctrico";
        int health = 150;
        Wizard wizard = new Wizard(name, health);
        Assert.That(wizard.Name, Is.EqualTo(name));
        Assert.That(wizard.Health, Is.EqualTo(health));
        Assert.That(wizard.BaseHealth, Is.EqualTo(health));
    }

    [Test]
    public void TestItems()
    {
        //En este testeo si funcionan los metodos para agregar y sacar items
        string name = "Mago Eléctrico";
        int health = 150;
        Wizard wizard = new Wizard(name, health);
        Staff itemAtt = new Staff("Staff");
        Armor itemDef = new Armor("Capa");
        wizard.AddMagicItem(itemAtt);
        wizard.AddItem(itemDef);
        Assert.That(wizard.GetMagicItems(), Does.Contain(itemAtt));
        Assert.That(wizard.GetItems(), Does.Contain(itemDef));
        wizard.RemoveMagicItem(itemAtt);
        wizard.RemoveItem(itemDef);
        Assert.That(wizard.GetMagicItems(), Is.Empty);
        Assert.That(wizard.GetItems(), Is.Empty);
    }

    [Test]
    public void TestAttack()
    {
        //Testeo el metodo para atacar Dwarf
        Wizard wizard = new Wizard("Mago Eléctrico", 150);
        Staff itemAtt = new Staff("Staff");
        Helmet itemDef = new Helmet("Squire's Helm");
        wizard.AddMagicItem(itemAtt);
        wizard.AddItem(itemDef);
        Skeleton skeleton = new Skeleton("Pepe", 70, 3);
        wizard.Attack(skeleton);
        Assert.That(skeleton.GetHealth(), Is.Not.EqualTo(120));
    }

    [Test]
    public void Heal()
    {
        //Testeo el recibir el ataque y la funcion Heal, la cual deberia restaurar la vida.
        Wizard wizard = new Wizard("Mago Eléctrico", 150);
        Skeleton skeleton = new Skeleton("Pepe", 70, 3);
        Axe itemAtt = new Axe( "Dwarven Axe");
        skeleton.AddItem(itemAtt);
        skeleton.Attack(wizard);
        Assert.That(wizard.GetHealth(), Is.EqualTo(135));
        wizard.Heal();
        Assert.That(wizard.GetHealth(), Is.EqualTo(150));
    }
    [Test]
    public void SpellBook()
    {
        //En este testeo que los magos solo puedan tener un SpellBook
        string name = "Mago";
        int health = 150;
        Wizard wizard = new Wizard(name, health);
        
        Spell fireBall = new Spell("FireBall", 15);
        SpellBook spellBook1 = new SpellBook();
        spellBook1.AddSpell(fireBall);
        wizard.AddMagicItem(spellBook1);
        
        Assert.That(wizard.GetMagicItems()[0], Is.EqualTo(spellBook1));
        
        Spell iceBall = new Spell("IceBall", 10);
        SpellBook spellBook2 = new SpellBook();
        spellBook2.AddSpell(fireBall);
        spellBook2.AddSpell(iceBall);
        wizard.AddMagicItem(spellBook2);
        
        Assert.That(wizard.GetMagicItems()[0], Is.EqualTo(spellBook2));
        Assert.That(wizard.GetMagicItems()[0], Is.Not.EqualTo(spellBook1));
    }
}