using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class hero
    {
        int energyget = 5;
        public string Name { get; set; } = "Pepan";
        public int HP { get; set; } = 10;
        public int DMG { get; set; } = 1;
        public int Energy { get; set; } = 3;
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

       
    }
}
