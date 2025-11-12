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
        public double HP { get; set; } = 0;
        public double Strenght { get; set; } = 0;
        public double Energy { get; set; } = 0;
        public double Armor { get; set; } = 0;
        public double Mana { get; set; } = 0;

        public hero(string HeroName)
        {
            Name = HeroName;
        }
           

       /* public void HeroAttack(enemies enemy1)
        {
            if (Energy >= 2)
            {
                enemy1.HP -= DMG;
                Energy -= 2;
            }
            else
            {
                Energy += energyget; // resting to get energy back
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Resting to regain energy!");
                Console.ResetColor();
            }
        }*/
    }
}



