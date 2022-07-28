using System;
using HeroBattle.Models;
using HeroBattle.Models.Heros;

namespace HeroBattle
{
    public static class BattleHelper
    {
        public static BaseHero GenerateHero(string question)
        {
            BaseHero hero;
            do
            {
                Console.WriteLine(question);
                var response = Console.ReadLine();
                hero = GetHero(response);
                if (hero == null)
                {
                    Console.WriteLine("Try again");
                }
            }
            while (hero == null);
            return hero;
        }

        public static BaseHero GetHero(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result switch
                {
                    1 => new CapitanAmerica(),
                    2 => new IronMan(),
                    3 => new SpiderMan(),
                    4 => new Tor(),
                    _ => null,
                };
            }
            return null;
        }

        public static int GetGameType(string question)
        {
            // 1 - 1X1 2 - 2X2
            int result = 0;

            do
            {
                Console.WriteLine(question);
                var response = Console.ReadLine();
                if(response == "1" || response == "2" )
                {
                    result = int.Parse(response);
                }
                else
                {
                    result = 0;
                }
            } while (result == 0);

            return result;
        }
    }
}
