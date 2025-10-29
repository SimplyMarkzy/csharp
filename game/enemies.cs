using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class enemies
    {
        public string RaceType {  get; set; }
        public int HP { get; set; }
        public int DMG { get; set; }

        public enemies(string raceType, int hP, int dMG)
        {
            RaceType = raceType;
            HP = hP;
            DMG = dMG;
        }
        public void EnemyAttack(hero myHero)
        {
            myHero.HP = myHero.HP - DMG;
        }
    }
}
