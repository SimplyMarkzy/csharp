using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class enemies
    {
        public string RaceType { get; set; }
        public double HP { get; set; }
        public double DMG { get; set; }

        public enemies(string raceType, double hP, double dMG)
        {
            RaceType = raceType;
            HP = hP;
            DMG = dMG;
        }

        public void EnemyAttack(hero myHero)
        {
            // 1 armor = 0.01% = 0.0001 dmg reduction
            double reduce = myHero.Armor * 0.0001;

            // Cap between 0 and 90%
            if (reduce < 0) reduce = 0;
            if (reduce > 0.90) reduce = 0.90;

            double finalDamage = DMG * (1 - reduce);
            finalDamage = Math.Max(0, finalDamage);

            myHero.HP -= finalDamage;
        }
    }
}

