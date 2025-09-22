using Library;

namespace LibraryTests;

public class TestDwarves
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestNameAndHealth()
    {
        // En este testeo creo un objeto Dwarves testeando los nombres y la vida
        string name = "Gimli";
        int health = 150;
        Dwarves dwarf = new Dwarves(name, health);
        Assert.That(dwarf.Name, Is.EqualTo(name));
        Assert.That(dwarf.Health, Is.EqualTo(health));
        Assert.That(dwarf.BaseHealth, Is.EqualTo(health));
    }

    [Test]
    public void TestItems()
    {
        //En este testeo si funcionan los metodos para agregar y sacar items
        string name = "Gimli";
        int health = 150;
        Dwarves dwarf = new Dwarves(name, health);
        Item itemAtt = new Item(0, 2, "Dwarven Axe");
        Item itemDef = new Item(2, 0, "Squire's Helm");
        dwarf.AddItem(itemAtt);
        dwarf.AddItem(itemDef);
        Assert.That(dwarf.GetItems(), Does.Contain(itemAtt));
        Assert.That(dwarf.GetItems(), Does.Contain(itemDef));
        dwarf.RemoveItem(itemAtt);
        dwarf.RemoveItem(itemDef);
        Assert.That(dwarf.GetItems(), Is.Empty);
    }

    [Test]
    public void TestAttackDwarf()
    {
        //Testeo el metodo para atacar a otro Dwarf
        Dwarves dwarf = new Dwarves("Gimli", 150);
        Item itemAtt = new Item(0, 2, "Dwarven Axe");
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
        //Testeo el metodo para atacar a los elfos
        Dwarves dwarf = new Dwarves("Gimli", 150);
        Item itemAtt = new Item(0, 2, "Dwarven Axe");
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
        Dwarves dwarf = new Dwarves("Gimli", 150);
        Item itemAtt = new Item(0, 2, "Dwarven Axe");
        Item itemDef = new Item(2, 0, "Squire's Helm");
        dwarf.AddItem(itemAtt);
        dwarf.AddItem(itemDef);
        Wizards wizardTarget = new Wizards("Gandalf", 70);
        dwarf.AttackWizards(wizardTarget);
        Assert.That(wizardTarget.GetHealth(), Is.Not.EqualTo(70));
    }
    
    [Test]
    public void Heal()
    {
        //Testeo el recibir el ataque y la funcion Heal, la cual deberia restaurar la vida.
        Dwarves dwarf1 = new Dwarves("Gimli", 150);
        Dwarves dwarf2 = new Dwarves("Gruñon", 100);
        Item itemAtt = new Item(0, 10, "Dwarven Axe");
        dwarf2.AddItem(itemAtt);
        dwarf2.AttackDwarves(dwarf1);
        Assert.That(dwarf1.GetHealth(), Is.EqualTo(140));
        dwarf1.Heal();
        Assert.That(dwarf1.GetHealth(), Is.EqualTo(150));

    }
}