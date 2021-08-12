using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
     public class Guards : badGuys
    {
        public bool HasShield { get; set; }

        public Guards(string name, int hitChance, int block, int life, int maxLife, int maxDamage, string description, int minDamage, bool hasShield)
            : base(name, hitChance, block, life, maxLife, maxDamage, description, minDamage)
        {
            HasShield = hasShield;
            if (HasShield)
            {
                Block += 10;
                Attack += 10;
                Description += "\nThey are hiding behind a shield!";
            }//end if IsCeilingCrawler

        }//end FQCTOR
    }
}
