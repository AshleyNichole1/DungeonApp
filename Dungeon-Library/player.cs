using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Player: Characters
    {
        public faction Playerfaction { get; set; }
         public weapon EquippedWeapon { get; set; }

         public Player(string name, int hitChance, int block, int life, int maxlife, faction playerfaction, weapon equippedweapon)
             : base(name, hitChance, block, life, maxlife)
         {
             Playerfaction = playerfaction;
             EquippedWeapon = equippedweapon;
             switch (Playerfaction)
             {
                 case faction.Abnegation:
                     Maxlife += 10;
                     Life += 10;
                     Attack -= 5;
                     break;
                 case faction.Amity:
                     Attack += 5;
                     Block += 5;
                     Maxlife += 10;
                     Life -= 10;
                     break;
                 case faction.Candor:
                     Block += 5;
                     Maxlife -= 5;
                     Life -= 5;
                     break;
                 case faction.Dauntless:
                     Attack += 10;
                     Block -= 5;
                     Maxlife -= 5;
                     Life += 5;
                     break;
                 case faction.Erudite:
                     Maxlife -= 10;
                     Life -= 10;
                     Attack += 10;
                     break;                

             }//end switch


         }//end fqctor*/

         public override string ToString()
         {
             return string.Format($"{Name}\nRace: {Playerfaction}\nLife: {Life} of {Maxlife}\n" +
                 $"Equipped Weapon:\n{EquippedWeapon}\nHit Chance: {Attack}%\n" +
                 $"Block Chance: {Block}%");
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
