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
        Dwarves dwarf = new Dwarves("Gimli", 150);
        Item itemAtt = new Item(0, 2, "Dwarven Axe");
        Item itemDef = new Item(2, 0, "Squire's Helm");
        dwarf.AddItem(itemAtt);
        dwarf.AddItem(itemDef);
        Wizards wizardTarget = new Wizards("Gandalf", 70);
        dwarf.AttackWizards(wizardTarget);
        Assert.That(wizardTarget.GetHealth(), Is.Not.EqualTo(70));
    }
}