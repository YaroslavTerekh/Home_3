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
            int GameType = BattleHelper.GetGameType("Select type game. (1, 2)");

            if(GameType == 1)
            {
                BaseHero hero1 = BattleHelper.GenerateHero("Please select a hero. (1,2,3,4)");
                BaseHero hero2 = BattleHelper.GenerateHero("Please select a second hero. (1,2,3,4)");

                hero1.AddSuperPower(
                    new ArmorSuperPowerService(),
                    SuperPowerGenerator.GenerateSuperPower());

                hero2.AddSuperPower(
                    new HPSuperPowerService(),
                    SuperPowerGenerator.GenerateSuperPower());

                Battle.Fight1x1(hero1, hero2);
            } 
            else if (GameType == 2)
            {
                BaseHero h1 = BattleHelper.GenerateHero("TEAM 1.Please select a hero. (1,2,3,4)");
                BaseHero h2 = BattleHelper.GenerateHero("TEAM 1.Please select a second hero. (1,2,3,4)");
                BaseHero h3 = BattleHelper.GenerateHero("TEAM 2.Please select a hero. (1,2,3,4)");
                BaseHero h4 = BattleHelper.GenerateHero("TEAM 2.Please select a second hero. (1,2,3,4)");

                BaseHero hero1 = h1 + h2;
                BaseHero hero2 = h3 + h4;

                hero1.AddSuperPower(
                    new ArmorSuperPowerService(),
                    SuperPowerGenerator.GenerateSuperPower());

                hero2.AddSuperPower(
                    new HPSuperPowerService(),
                    SuperPowerGenerator.GenerateSuperPower());

                Battle.Fight1x1(hero1, hero2);
            }

            Console.ReadKey();
        }

        
    }
}
