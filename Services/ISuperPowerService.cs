using System;
using HeroBattle.Models;

namespace HeroBattle.Services
{
    public interface ISuperPowerService
    {
        void AddSuperPower(BaseHero hero, int power);
    }
}
