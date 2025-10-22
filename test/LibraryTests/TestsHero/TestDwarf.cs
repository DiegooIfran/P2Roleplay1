using Library;
using Library.Characters;
using Library.Characters.Enemies;
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
    public void TestAttack()
    {
        //Testeo el metodo para atacar a otro Dwarf
        Dwarf dwarf = new Dwarf("Gimli", 150);
        Axe itemAtt = new Axe("Dwarven Axe");
        Helmet itemDef = new Helmet("Squire's Helm");
        dwarf.AddItem(itemAtt);
        dwarf.AddItem(itemDef);
        Demon demonTarget = new Demon("Carlos", 100, 10);
        dwarf.Attack(demonTarget);
        Assert.That(demonTarget.GetHealth(), Is.Not.EqualTo(120));
    }


    
    
    [Test]
    public void Heal()
    {
        //Testeo el recibir el ataque y la funcion Heal, la cual deberia restaurar la vida.
        Dwarf dwarf1 = new Dwarf("Gimli", 150);
        Axe itemAtt = new Axe("Dwarven Axe");
        Demon demonTarget = new Demon("Carlos", 100, 10);
        demonTarget.AddItem(itemAtt);
        demonTarget.Attack(dwarf1);
        Assert.That(dwarf1.GetHealth(), Is.EqualTo(135));
        dwarf1.Heal();
        Assert.That(dwarf1.GetHealth(), Is.EqualTo(150));

    }
}