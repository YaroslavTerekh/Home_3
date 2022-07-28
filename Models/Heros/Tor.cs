using System;
using HeroBattle.Services;

namespace HeroBattle.Models.Heros
{
    public class Tor : BaseHero
    {
        public override int Armor { get; set; } = 6;

        public override int Damage { get; set; } = 14;

        public override string ToString()
        {
            return "Tor";
        }
    }
}
