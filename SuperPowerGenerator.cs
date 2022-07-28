using System;
namespace HeroBattle
{
    public static class SuperPowerGenerator
    {
        public static int GenerateSuperPower()
        {
            return new Random().Next(5, 10);
        }
    }
}
