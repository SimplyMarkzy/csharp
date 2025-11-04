using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace game
{
    public class hero
    {
        int energyget = 5;

        public string Name { get; set; }
        public double HP { get; set; }
        public double DMG { get; set; }
        public double Energy { get; set; }
        public double Armor { get; set; }

        public hero(string name, double hp, double dmg, double energy, double armor)
        {
            Name = name;
            HP = hp;
            DMG = dmg;
            Energy = energy;
            Armor = armor;
        }

        public void HeroAttack(enemies enemy1)
        {
            if (Energy >= 2)
            {
                enemy1.HP -= DMG;
                Energy -= 2;
            }
            else
            {
                Energy += energyget; // resting to get energy back
            }
        }
    }
}



