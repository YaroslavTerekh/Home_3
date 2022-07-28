using System;
using HeroBattle.Models;

namespace HeroBattle.Services.Implementations
{
    public class ArmorSuperPowerService : ISuperPowerService
    {
        public void AddSuperPower(BaseHero hero, int power)
        {
            hero.Armor += power;
        }
    }
}
