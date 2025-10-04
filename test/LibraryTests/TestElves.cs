using Library;
using Ucu.Poo.RoleplayGame;

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
        //En este testeo creo un objeto Elves testeando los nombres y la vida
        const string name = "Legolas";
        const int health = 100;
        Elves elf = new Elves(name, health);
        Assert.That(elf.Name, Is.EqualTo(name));
        Assert.That(elf.Health, Is.EqualTo(health));
        Assert.That(elf.BaseHealth, Is.EqualTo(health));
    }
    
    [Test]
    public void TestItems()
    {
        //En este testeo si funcionan los metodos para agregar y sacar items
        const string name = "Legolas";
        const int health = 100;
        Elves elf = new Elves(name, health);
        Bow itemAtt = new Bow("Bow");
        Shield itemDef = new Shield("Shield");
        elf.AddItem(itemAtt);
        elf.AddItem(itemDef);
        Assert.That(elf.GetItems(), Does.Contain(itemAtt));
        Assert.That(elf.GetItems(), Does.Contain(itemDef));
        elf.RemoveItem(itemAtt);
        elf.RemoveItem(itemDef);
        Assert.That(elf.GetItems(), Is.Empty);
    }
    
    [Test]
    public void TestAttackElf()
    {
        //Testeo el metodo para atacar a otro elfo
        Elves elfAtt = new Elves("Legolas", 100);
        Bow itemAtt = new Bow("Bow");
        Shield itemDef = new Shield("Shield");
        elfAtt.AddItem(itemAtt);
        elfAtt.AddItem(itemDef);
        Elves elfDef = new Elves("Galadriel", 100);
        elfAtt.Attack(elfDef);
        Assert.That(elfDef.Health, Is.Not.EqualTo(100));
    }
    
    [Test]
    public void TestAttackDwarf()
    {
        //Testeo el metodo para atacar a los enanos
        Elves elfAtt = new Elves("Legolas", 100);
        Bow itemAtt = new Bow("Bow");
        Shield itemDef = new Shield("Shield");
        elfAtt.AddItem(itemAtt);
        elfAtt.AddItem(itemDef);
        Dwarves dwarf = new Dwarves("Durin", 120);
        elfAtt.Attack(dwarf);
        Assert.That(dwarf.Health, Is.Not.EqualTo(120));
    }
    
    [Test]
    public void TestAttackWizard()
    {
        //Testeo el metodo para atacar a los magos
        Elves elfAtt = new Elves("Legolas", 100);
        Bow itemAtt = new Bow("Bow");
        Shield itemDef = new Shield("Shield");
        elfAtt.AddItem(itemAtt);
        elfAtt.AddItem(itemDef);
        Wizards wizard = new Wizards("Gandalf", 80);
        elfAtt.Attack(wizard);
        Assert.That(wizard.Health, Is.Not.EqualTo(80));
    }
    
    [Test]
    public void Heal()
    {
        //Testeo el recibir el ataque y la funcion Heal, la cual deberia restaurar la vida.
        Elves elf1 = new Elves("Legolas", 100);
        Elves elf2 = new Elves("Galadriel", 100);
        Bow itemAtt = new Bow("Bow");
        elf2.AddItem(itemAtt);
        elf2.Attack(elf1);
        Assert.That(elf1.GetHealth(), Is.EqualTo(90));
        elf1.Heal();
        Assert.That(elf1.GetHealth(), Is.EqualTo(100));
    }
}