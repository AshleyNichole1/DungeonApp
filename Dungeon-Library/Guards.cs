using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
     public class Guards : BadGuys
    {
       

        public Guards(string name, int hitChance, int block, int life, int maxLife, int maxDamage, string description, int minDamage)
            : base(name, hitChance, block, life, maxLife, maxDamage, description, minDamage)
        {
       

        }//end FQCTOR
    }
}
