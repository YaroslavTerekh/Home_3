using System;
using HeroBattle.Models;

namespace HeroBattle.Services.Implementations
{
    public class HPSuperPowerService : ISuperPowerService
    {
        public void AddSuperPower(BaseHero hero, int power)
        {
            hero.HealthPoint += power;
        }
    }
}
