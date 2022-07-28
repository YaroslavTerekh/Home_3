using System;
using HeroBattle.Services;
using HeroBattle.Models;

namespace HeroBattle.Models
{
    public abstract class BaseHero
    {
        public int HealthPoint { get; set; } = 100;

        public virtual int Armor { get; set; } = 10;

        public virtual int Damage { get; set; } = 10;

        public bool IsAlive => HealthPoint > 0;

        public virtual void AddSuperPower(ISuperPowerService powerService, int power)
        {
            powerService.AddSuperPower(this, power);
        }

        public int Attack()
        {
            if (Armor > 0)
                return Damage;
            if (Damage == 1)
                return 1;
            return --Damage;
        }

        public void Defense(int power)
        {
            if (Armor > 0)
            {
                var check = power / 2;
                if (check < Armor)
                {
                    Armor -= check;
                }
                else
                {
                    var ext = check - Armor;
                    HealthPoint -= ext;
                    Armor = 0;
                }

                HealthPoint -= (power - check);
            }
            else
            {
                HealthPoint -= power;
            }
        }

        public override string ToString()
        {
            return "Base Hero";
        }

        public static BaseHero operator + (BaseHero hero1, BaseHero hero2) {
            return new UnknownHero {
                Armor = hero1.Armor + hero2.Armor,
                Damage = hero1.Damage + hero2.Damage,
                HealthPoint = hero1.HealthPoint + hero2.HealthPoint,
            };
        }
    }
}
