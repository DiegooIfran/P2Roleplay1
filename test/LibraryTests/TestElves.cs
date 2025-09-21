namespace LibraryTests;

public class TestElves
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestNameAndHealth()
    {
        const string name = "Legolas";
        const int health = 100;
        Elves elf = new Elves(name, health);
        Assert.That(elf.Name, Is.EqualTo(name));
        Assert.That(elf.Health, Is.EqualTo(health));
        Assert.That(elf.MaxHealth, Is.EqualTo(health));
    }
    
    [Test]
    public void TestItems()
    {
        const string name = "Legolas";
        const int health = 100;
        Elves elf = new Elves(name, health);
        Item itemAtt = new Item("Bow", 5, 0);
        Item itemDef = new Item("Cloak", 0, 3);
        elf.AddItem(itemAtt);
        elf.AddItem(itemDef);
        Assert.That(elf.Items(0), Is.EqualTo(itemAtt));
        Assert.That(elf.Items(1), Is.EqualTo(itemDef));
        elf.RemoveItem(itemAtt);
        elf.RemoveItem(itemDef);
        Assert.That(elf.Items(), Is.EqualTo(null));
    }
    
    [Test]
    public void TestAttackElf()
    {
        Elves elfAtt = new Elves("Legolas", 100);
        Item itemAtt = new Item("Bow", 5, 0);
        Item itemDef = new Item("Cloak", 0, 3);
        elfAtt.AddItem(itemAtt);
        elfAtt.AddItem(itemDef);
        Elves elfDef = new Elves("Galadriel", 100);
        elfAtt.AttackElves(elfDef);
        Assert.That(elfDef.Health, Is.Not.EqualTo(100));
    }
    
    [Test]
    public void TestAttackDwarf()
    {
        Elves elfAtt = new Elves("Legolas", 100);
        Item itemAtt = new Item("Bow", 5, 0);
        Item itemDef = new Item("Cloak", 0, 3);
        elfAtt.AddItem(itemAtt);
        elfAtt.AddItem(itemDef);
        Dwarves dwarf = new Dwarves("Durin", 120);
        elfAtt.AttackDwarves(dwarf);
        Assert.That(dwarf.Health, Is.Not.EqualTo(120));
    }
    
    [Test]
    public void TestAttackWizard()
    {
        Elves elfAtt = new Elves("Legolas", 100);
        Item itemAtt = new Item("Bow", 5, 0);
        Item itemDef = new Item("Cloak", 0, 3);
        elfAtt.AddItem(itemAtt);
        elfAtt.AddItem(itemDef);
        Wizards wizard = new Wizards("Gandalf", 80);
        elfAtt.AttackElves(wizard);
        Assert.That(wizard.Health, Is.Not.EqualTo(80));
    }
}