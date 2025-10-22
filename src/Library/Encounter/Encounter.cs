namespace Library.Encounter;
using Library.Characters.Heroes;
using Library.Characters;

public static class Encounter
{
    public static void DoEncounter(HeroTeam heroes, EnemyTeam enemies)
    {
        List<Hero> heroTeam = heroes.GetTeam();
        List<Enemy> enemyTeam = enemies.GetTeam();
        while(enemyTeam.Count != 0 && heroTeam.Count() != 0)
        {
            if (heroTeam.Count() == enemyTeam.Count())
            {
                for (int i = 0; i < heroTeam.Count(); i++)
                {
                    enemyTeam[i].Attack(heroTeam[i]);
                }
            }
            else if (heroTeam.Count() == 1)
            {
                foreach (Enemy enemy in enemyTeam)
                {
                    enemy.Attack(heroTeam[0]);
                }
            }
            else if (heroTeam.Count() < enemyTeam.Count())
            {
                for (int aux = 0; aux < enemyTeam.Count(); aux++)
                {
                    for (int i = 0; i < heroTeam.Count(); i++)
                    {
                        enemyTeam[aux].Attack(heroTeam[i]);
                    }
                }
            }

            foreach (Hero hero in heroTeam)
            {
                foreach (Enemy enemy in enemyTeam)
                {
                    hero.Attack(enemy);
                    if (enemy.GetHealth() == 0)
                    {
                        hero.VictoryPoints += enemy.VictoryPoints;
                    }
                }
            }
        }

        foreach (Hero hero in heroTeam)
        {
            if (hero.VictoryPoints >= 5 && hero.GetHealth() > 0)
            {
                hero.Heal();
                hero.VictoryPoints = 0;
            }
        }
    }
}