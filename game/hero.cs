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
        public int HP { get; set; } 
        public int DMG { get; set; }
        public int Energy { get; set; }
        public int Armor { get; set; }

        public void HeroAttack(enemies enemy1)
        {
            if (Energy -2 >= 1)
            {
                enemy1.HP = enemy1.HP - DMG;
                Energy = Energy - 2;
                
            }
            else
            {
                Energy = Energy + energyget;
            }   
                

        }
        public double AttackReduction(hero MyHero, enemies enemy1)
        {
            if (MyHero.Armor != 0)
            {
                return   20 / 100 * MyHero.Armor;
            }
            double DamageReduced = enemy1.DMG * MyHero.Armor;
               
        }
        public hero(string Name, int hP, int dMG, int Energy, int Armor)
        {
            Name = Name;
            HP = hP;
            DMG = dMG;
        }
    }
}
