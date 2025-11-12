using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    // Class to hold hero attributes
    public class Attributes
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Mana { get; set; }
        public int Energy { get; set; }
        public int PointsLeft { get; set; } = 20;
    }
}
