using System;
using HeroBattle.Models;

namespace HeroBattle
{
    public static class Battle
    {
        public static void Fight1x1(BaseHero hero1, BaseHero hero2)
        {
            int roundCount = 0;
            do
            {
                Console.WriteLine($"Round {++roundCount}");
                hero2.Defense(hero1.Attack());
                hero1.Defense(hero2.Attack());
            } while (hero1.IsAlive && hero2.IsAlive);

            var winner = hero1.IsAlive
                ? hero1
                : hero2.IsAlive
                    ? hero2
                    : null;

            var looser = winner != hero1
                ? hero1
                : hero2;

            if (winner != null)
            {
                Console.WriteLine($"{winner} won in {roundCount} round.\n HP left {winner.HealthPoint}.\n Looser is {looser}.");
            }
            else
            {
                Console.WriteLine("No winners");
            }
        }

        public static void Fight2x2(BaseHero h1, BaseHero h2, BaseHero h3, BaseHero h4)
        {
            BaseHero hero1 = h1 + h2;
            BaseHero hero2 = h3 + h4;

            int roundCount = 0;
            do
            {
                Console.WriteLine($"Round {++roundCount}");
                hero2.Defense(hero1.Attack());
                hero1.Defense(hero2.Attack());
            } while (hero1.IsAlive && hero2.IsAlive);

            var winner = hero1.IsAlive
                ? hero1
                : hero2.IsAlive
                    ? hero2
                    : null;

            var looser = winner != hero1
                ? hero1
                : hero2;

            if (winner != null)
            {
                Console.WriteLine($"{winner} won in {roundCount} round.\n HP left {winner.HealthPoint}.\n Looser is {looser}.");
            }
            else
            {
                Console.WriteLine("No winners");
            }
        }
    }
}
