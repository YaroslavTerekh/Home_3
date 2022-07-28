using System;
namespace HeroBattle.Models.Heros
{
    public class SpiderMan : BaseHero
    {
        public override int Armor { get; set; } = 8;

        public override int Damage { get; set; } = 12;

        public override string ToString()
        {
            return "Spider Man";
        }
    }
}
