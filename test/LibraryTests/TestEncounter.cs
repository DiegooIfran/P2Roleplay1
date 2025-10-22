using Library;
using Library.Characters;
using Library.Characters.Enemies;
using Library.Characters.Heroes;
using Library.Encounter;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestEncounter
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void EnemiesAttackFirst()
    {
        // Los enemigos atacan primero
        Hero hero = new Dwarf("Arthur", 100);
        Enemy enemy = new Goblin("Grub", 100, 2);
        Sword sword = new Sword("Rusty Sword");
        enemy.AddItem(sword);

        HeroTeam heroTeam = new HeroTeam("Heroes");
        heroTeam.AddToTeam(hero);

        EnemyTeam enemyTeam = new EnemyTeam("Enemies");
        enemyTeam.AddToTeam(enemy);

        Encounter.DoEncounter(heroTeam, enemyTeam);
        Assert.That(hero.Health, Is.LessThan(100));
    }

    [Test]
    public void HeroGainsVictoryPoints_WhenEnemyDies()
    {
        Hero hero = new Elf("Legolas", 100);
        Enemy enemy = new Skeleton("Bones", 10, 3);
        Sword bow = new Sword("Bow");
        hero.AddItem(bow);

        HeroTeam heroTeam = new HeroTeam("Heroes");
        heroTeam.AddToTeam(hero);
        EnemyTeam enemyTeam = new EnemyTeam("Enemies");
        enemyTeam.AddToTeam(enemy);

        Encounter.DoEncounter(heroTeam, enemyTeam);
        Assert.That(hero.VictoryPoints, Is.GreaterThanOrEqualTo(3));
    }

    [Test]
    public void HeroHeals_FiveOrMoreVictoryPoints()
    {
        Hero hero = new Elf("Legolas", 60);
        hero.AddItem(new Sword("Sword"));
        Enemy enemy1 = new Skeleton("Bones", 10, 3);
        Enemy enemy2 = new Goblin("Grub", 10, 3);

        HeroTeam heroTeam = new HeroTeam("Heroes");
        heroTeam.AddToTeam(hero);
        EnemyTeam enemyTeam = new EnemyTeam("Enemies");
        enemyTeam.AddToTeam(enemy1);
        enemyTeam.AddToTeam(enemy2);

        Encounter.DoEncounter(heroTeam, enemyTeam);

        Assert.That(hero.Health, Is.EqualTo(hero.BaseHealth)); // Debe haberse curado
        Assert.That(hero.VictoryPoints, Is.EqualTo(0)); // VP se reinicia cuando se cura
    }

    [Test]
    public void EncounterEnds_WhenAllEnemiesOrHeroesDie()
    {
        Wizard hero = new Wizard("Gandalf", 100);
        hero.AddItem(new Sword("Staff"));
        Enemy enemy = new Skeleton("Bones", 1, 2);
        enemy.AddItem(new Sword("Bone Sword"));

        HeroTeam heroTeam = new HeroTeam("Heroes");
        heroTeam.AddToTeam(hero);
        EnemyTeam enemyTeam = new EnemyTeam("Enemies");
        enemyTeam.AddToTeam(enemy);

        Encounter.DoEncounter(heroTeam, enemyTeam);

        Assert.That(enemy.Health, Is.EqualTo(0));
    }
}