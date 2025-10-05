using Library;
using Library.Characters;

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
        Item itemAtt = new Item(0, 2, "Anillo Mágico");
        Item itemDef = new Item(2, 0, "Capa");
        wizard.AddItem(itemAtt);
        wizard.AddItem(itemDef);
        Assert.That(wizard.GetItems(), Does.Contain(itemAtt));
        Assert.That(wizard.GetItems(), Does.Contain(itemDef));
        wizard.RemoveItem(itemAtt);
        wizard.RemoveItem(itemDef);
        Assert.That(wizard.GetItems(), Is.Empty);
    }

    [Test]
    public void TestAttackDwarf()
    {
        //Testeo el metodo para atacar Dwarf
        Wizards dwarf = new Wizards("Mago Eléctrico", 150);
        Item itemAtt = new Item(0, 2, "Anillo Mágico");
        Item itemDef = new Item(2, 0, "Squire's Helm");
        dwarf.AddItem(itemAtt);
        dwarf.AddItem(itemDef);
        Dwarves dwarfTarget = new Dwarves("Gruñon", 120);
        dwarf.AttackDwarves(dwarfTarget);
        Assert.That(dwarfTarget.GetHealth(), Is.Not.EqualTo(120));
    }

    [Test]
    public void TestAttackElf()
    {
        //Testeo el metodo para atacar Elfo
        Wizards dwarf = new Wizards("Mago Eléctrico", 150);
        Item itemAtt = new Item(0, 2, "Anillo Mágico");
        Item itemDef = new Item(2, 0, "Squire's Helm");
        dwarf.AddItem(itemAtt);
        dwarf.AddItem(itemDef);
        Elves elfTarget = new Elves("Legolas", 100);
        dwarf.AttackElves(elfTarget);
        Assert.That(elfTarget.GetHealth(), Is.Not.EqualTo(100));
    }

    [Test]
    public void TestAttackWizards()
    {
        //Testeo el metodo para atacar a los magos
        Wizards wizard1 = new Wizards("Mago Eléctrico", 150);
        Item itemAtt = new Item(0, 2, "Dwarven Axe");
        Item itemDef = new Item(2, 0, "Squire's Helm");
        wizard1.AddItem(itemAtt);
        wizard1.AddItem(itemDef);
        Wizards wizard2 = new Wizards("Gandalf", 70);
        wizard1.AttackWizards(wizard2);
        Assert.That(wizard2.GetHealth(), Is.Not.EqualTo(70));
    }
    
    [Test]
    public void Heal()
    {
        //Testeo el recibir el ataque y la funcion Heal, la cual deberia restaurar la vida.
        Wizards wizard = new Wizards("Mago Eléctrico", 150);
        Dwarves dwarf = new Dwarves("Gruñon", 100);
        Item itemAtt = new Item(0, 10, "Dwarven Axe");
        dwarf.AddItem(itemAtt);
        dwarf.AttackWizards(wizard);
        Assert.That(wizard.GetHealth(), Is.EqualTo(140));
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