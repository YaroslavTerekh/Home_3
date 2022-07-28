using System;
using HeroBattle.Models;

namespace HeroBattle.Services.Implementations
{
    public class DamageSuperPowerService : ISuperPowerService
    {
        public void AddSuperPower(BaseHero hero, int power)
        {
            hero.Damage += power;
        }
    }
}
