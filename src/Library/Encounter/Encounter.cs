namespace Library.Encounter;

public static class Encounter
{
    static void DoEncounter(HeroTeam heroes, EnemyTeam enemies)
    {
        List<Hero> heroTeam = heroes.GetTeam();
        List<Enemy> enemyTeam = enemies.GetTeam();
        while(enemyTeam.Length() != 0 && heroTeam.Length() != 0)
        {
            if (heroTeam.Length() == enemyTeam.Length())
            {
                for (int i = 0; i < heroTeam.Length(); i++)
                {
                    enemyTeam[i].Attack(heroTeam[i]);
                }
            }
            else if (heroTeam.Length() == 1)
            {
                foreach (Enemy enemy in enemyTeam)
                {
                    enemy.Attack(heroTeam[0]);
                }
            }
            else if (heroTeam.Length() < enemyTeam.Length())
            {
                for (int aux = 0; aux < enemyTeam.Length(); aux++)
                {
                    for (int i = 0; i < heroTeam.Length(); i++)
                    {
                        enemyTeam[aux].Attack(heroTeam[i]);
                    }
                }
            }

            foreach (Hero hero in heroTeam)
            {
                foreach (Enemy enemy in enemyTeam)
                {
                    hero.Attach(enemy);
                    if (enemy.GetHealth() == 0)
                    {
                        hero.VP += enemy.VP;
                    }
                }
            }
        }

        foreach (Hero hero in heroTeam)
        {
            if (hero.VP >= 5 && hero.GetHealth() > 0)
            {
                hero.Heal();
                hero.VP = 0;
            }
        }
    }
}