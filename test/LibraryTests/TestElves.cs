using Library;

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
        Item itemAtt = new Item(0, 5, "Bow");
        Item itemDef = new Item(3, 0, "Cloak");
        elf.AddItem(itemAtt);
        elf.AddItem(itemDef);
        Assert.That(elf.Items, Does.Contain(itemAtt));
        Assert.That(elf.Items, Does.Contain(itemDef));
        elf.RemoveItem(itemAtt);
        elf.RemoveItem(itemDef);
        Assert.That(elf.Items, Is.Empty);
    }
    
    [Test]
    public void TestAttackElf()
    {
        Elves elfAtt = new Elves("Legolas", 100);
        Item itemAtt = new Item(0, 5, "Bow");
        Item itemDef = new Item(3, 0, "Cloak");
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
        Item itemAtt = new Item(0, 5, "Bow");
        Item itemDef = new Item(3, 0, "Cloak");
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
        Item itemAtt = new Item(0, 5, "Bow");
        Item itemDef = new Item(3, 0, "Cloak");
        elfAtt.AddItem(itemAtt);
        elfAtt.AddItem(itemDef);
        Wizards wizard = new Wizards("Gandalf", 80);
        elfAtt.AttackWizards(wizard);
        Assert.That(wizard.Health, Is.Not.EqualTo(80));
    }
    
    public void Heal()
    {
        //Testeo el recibir el ataque y la funcion Heal, la cual deberia restaurar la vida.
        Elves elf1 = new Elves("Legolas", 100);
        Elves elf2 = new Elves("Galadriel", 100);
        Item itemAtt = new Item(0, 10, "Bow");
        elf2.AddItem(itemAtt);
        elf2.AttackElves(elf1);
        Assert.That(elf1.GetHealth(), Is.EqualTo(90));
        elf1.Heal();
        Assert.That(elf1.GetHealth(), Is.EqualTo(100));
    }
}