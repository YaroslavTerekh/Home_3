using System;
using HeroBattle.Models;
using HeroBattle.Models.Heros;
using HeroBattle.Services.Implementations;

namespace HeroBattle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            BaseHero hero1 = BattleHelper.GenerateHero("Please select a hero. (1,2,3,4)");
            BaseHero hero2 = BattleHelper.GenerateHero("Please select a second hero. (1,2,3,4)");

            hero1.AddSuperPower(
                new ArmorSuperPowerService(),
                SuperPowerGenerator.GenerateSuperPower());

            hero2.AddSuperPower(
                new HPSuperPowerService(),
                SuperPowerGenerator.GenerateSuperPower());

            Battle.Fight(hero1, hero2);
            Console.ReadKey();
        }
    }
}
