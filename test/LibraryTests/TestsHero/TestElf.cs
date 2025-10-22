using Library;
using Library.Characters;
using Library.Characters.Enemies;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestElf
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
        Elf elf = new Elf(name, health);
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
        Elf elf = new Elf(name, health);
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
    public void TestAttack()
    {
        //Testeo el metodo para atacar a otro elfo
        Elf elfAtt = new Elf("Legolas", 100);
        Bow itemAtt = new Bow("Bow");
        Shield itemDef = new Shield("Shield");
        elfAtt.AddItem(itemAtt);
        elfAtt.AddItem(itemDef);;
        Demon demonDef = new Demon("Carlos", 100, 10);
        elfAtt.Attack(demonDef);
        Assert.That(demonDef.Health, Is.Not.EqualTo(100));
    }
    
    
    [Test]
    public void Heal()
    {
        //Testeo el recibir el ataque y la funcion Heal, la cual deberia restaurar la vida.
        Elf elf1 = new Elf("Legolas", 100);
        Bow itemAtt = new Bow("Bow");
        Demon demonAttack = new Demon("Carlos", 100, 10);
        demonAttack.AddItem(itemAtt);
        demonAttack.Attack(elf1);
        Assert.That(elf1.GetHealth(), Is.EqualTo(90));
        elf1.Heal();
        Assert.That(elf1.GetHealth(), Is.EqualTo(100));
    }
}