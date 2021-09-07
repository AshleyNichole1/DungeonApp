using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Player: Characters
    {
        public Faction Playerfaction { get; set; }
         public Weapon EquippedWeapon { get; set; }
        

        public Player(string name, int hitChance, int block, int life, int maxlife, Faction playerfaction, Weapon equippedweapon)
             : base(name, hitChance, block, life, maxlife)
         {
             Playerfaction = playerfaction;
             EquippedWeapon = equippedweapon;
             switch (Playerfaction)
             {
                 case Faction.Abnegation:
                     Maxlife += 10;
                     Life += 8;
                     Attack += 5;
                     Block += 2;
                   
                     break;
                 case Faction.Amity:
                     Attack += 2;
                     Block += 5;
                     Maxlife += 15;
                     Life += 10;
                  
                     break;
                 case Faction.Candor:
                     Block += 5;
                     Maxlife += 5;
                     Life += 5;
                  
                     break;
                 case Faction.Dauntless:
                     Attack += 10;
                     Block += 5;
                     Maxlife += 5;
                     Life += 5;
                  
                     break;
                 case Faction.Erudite:
                     Maxlife += 10;
                     Life += 10;
                     Attack += 10;
              
                     break;                

             }//end switch


         }//end fqctor*/

         public override string ToString()
         {
             return string.Format("Name: " + Name + "\nFaction: " +Playerfaction + "\nLife: " + Life + "\nMaxLife: " +Maxlife  +
                 "\nWeapon: " + EquippedWeapon + "Attack: " + Attack + "\nBlock: " + Block +"\n" );
         }

         public override int CalcDamage()
         {
             Random rand = new Random();

             int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
             return damage;
         }

         public override int CalcAttack()
         {
             return Attack + EquippedWeapon.BonusHitChance;
         }
         

      
    }

}
