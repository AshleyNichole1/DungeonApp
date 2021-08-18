using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
     public class Guards : BadGuys
    {
       

        public Guards(string name, int attack, int block, int life, int maxLife, int maxDamage, string description, int minDamage)
            : base(name, attack, block, life, maxLife, maxDamage, description, minDamage)
        {
       
            
        }


    }
}
