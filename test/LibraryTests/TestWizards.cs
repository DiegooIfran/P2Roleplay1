using Library;
using Library.Characters;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestWizards
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
        Wizards wizard = new Wizards(name, health);
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
        Wizards wizard = new Wizards(name, health);
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
    public void TestAttackDwarf()
    {
        //Testeo el metodo para atacar Dwarf
        Wizards dwarf = new Wizards("Mago Eléctrico", 150);
        Staff itemAtt = new Staff("Staff");
        Helmet itemDef = new Helmet("Squire's Helm");
        dwarf.AddMagicItem(itemAtt);
        dwarf.AddItem(itemDef);
        Dwarves dwarfTarget = new Dwarves("Gruñon", 120);
        dwarf.Attack(dwarfTarget);
        Assert.That(dwarfTarget.GetHealth(), Is.Not.EqualTo(120));
    }

    [Test]
    public void TestAttackElf()
    {
        //Testeo el metodo para atacar Elfo
        Wizards wizard = new Wizards("Mago Eléctrico", 150);
        Staff itemAtt = new Staff("Staff");
        Helmet itemDef = new Helmet("Squire's Helm");
        wizard.AddMagicItem(itemAtt);
        wizard.AddItem(itemDef);
        Elves elfTarget = new Elves("Legolas", 100);
        wizard.Attack(elfTarget);
        Assert.That(elfTarget.GetHealth(), Is.Not.EqualTo(100));
    }

    [Test]
    public void TestAttackWizards()
    {
        //Testeo el metodo para atacar a los magos
        Wizards wizard1 = new Wizards("Mago Eléctrico", 150);
        Axe itemAtt = new Axe("Dwarven Axe");
        Helmet itemDef = new Helmet("Squire's Helm");
        wizard1.AddItem(itemAtt);
        wizard1.AddItem(itemDef);
        Wizards wizard2 = new Wizards("Gandalf", 70);
        wizard1.Attack(wizard2);
        Assert.That(wizard2.GetHealth(), Is.Not.EqualTo(70));
    }
    
    [Test]
    public void Heal()
    {
        //Testeo el recibir el ataque y la funcion Heal, la cual deberia restaurar la vida.
        Wizards wizard = new Wizards("Mago Eléctrico", 150);
        Dwarves dwarf = new Dwarves("Gruñon", 100);
        Axe itemAtt = new Axe( "Dwarven Axe");
        dwarf.AddItem(itemAtt);
        dwarf.Attack(wizard);
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
        Wizards wizard = new Wizards(name, health);
        
        Spell fireBall = new Spell("FireBall", 15);
        SpellBook spellBook1 = new SpellBook();
        spellBook1.AddSpell(fireBall);
        wizard.AddSpellBook(spellBook1);
        
        Assert.That(wizard.SpellBook, Is.EqualTo(spellBook1));
        
        Spell iceBall = new Spell("IceBall", 10);
        SpellBook spellBook2 = new SpellBook();
        spellBook2.AddSpell(fireBall);
        spellBook2.AddSpell(iceBall);
        wizard.AddSpellBook(spellBook2);
        
        Assert.That(wizard.SpellBook, Is.EqualTo(spellBook2));
        Assert.That(wizard.SpellBook, Is.Not.EqualTo(spellBook1));
    }
}