using Library;
using Library.Characters;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestDwarf
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
        Dwarf dwarf = new Dwarf(name, health);
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
        Dwarf dwarf = new Dwarf(name, health);
        Axe itemAtt = new Axe("Dwarven Axe");
        Helmet itemDef = new Helmet("Squire's Helm");
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
        Dwarf dwarf = new Dwarf("Gimli", 150);
        Axe itemAtt = new Axe("Dwarven Axe");
        Helmet itemDef = new Helmet("Squire's Helm");
        dwarf.AddItem(itemAtt);
        dwarf.AddItem(itemDef);
        Dwarf dwarfTarget = new Dwarf("Gruñon", 120);
        dwarf.Attack(dwarfTarget);
        Assert.That(dwarfTarget.GetHealth(), Is.Not.EqualTo(120));
    }

    [Test]
    public void TestAttackElf()
    {
        //Testeo el metodo para atacar a los elfos
        Dwarf dwarf = new Dwarf("Gimli", 150);
        Axe itemAtt = new Axe( "Dwarven Axe");
        Helmet itemDef = new Helmet( "Squire's Helm");
        dwarf.AddItem(itemAtt);
        dwarf.AddItem(itemDef);
        Elf elfTarget = new Elf("Legolas", 100);
        dwarf.Attack(elfTarget);
        Assert.That(elfTarget.GetHealth(), Is.Not.EqualTo(100));
    }

    [Test]
    public void TestAttackWizards()
    {
        //Testeo el metodo para atacar a los magos
        Dwarf dwarf = new Dwarf("Gimli", 150);
        Axe itemAtt = new Axe("Dwarven Axe");
        Helmet itemDef = new Helmet( "Squire's Helm");
        dwarf.AddItem(itemAtt);
        dwarf.AddItem(itemDef);
        Wizard wizardTarget = new Wizard("Gandalf", 70);
        dwarf.Attack(wizardTarget);
        Assert.That(wizardTarget.GetHealth(), Is.Not.EqualTo(70));
    }
    
    [Test]
    public void Heal()
    {
        //Testeo el recibir el ataque y la funcion Heal, la cual deberia restaurar la vida.
        Dwarf dwarf1 = new Dwarf("Gimli", 150);
        Dwarf dwarf2 = new Dwarf("Gruñon", 100);
        Axe itemAtt = new Axe("Dwarven Axe");
        dwarf2.AddItem(itemAtt);
        dwarf2.Attack(dwarf1);
        Assert.That(dwarf1.GetHealth(), Is.EqualTo(135));
        dwarf1.Heal();
        Assert.That(dwarf1.GetHealth(), Is.EqualTo(150));

    }
}