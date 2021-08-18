using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class War 
    {
        public static void Attack(Characters attacker, Characters defender)
        {
            
            int diceroll = new Random().Next(1, 101);
           
            System.Threading.Thread.Sleep(35);
            if (diceroll <= attacker.CalcAttack() - defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;
               
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
               

            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }

        }

        public static void Battle(Player divergent, BadGuys guards)
        {
            Attack(divergent, guards);
            if (guards.Life > 0)
            {
                Attack(guards, divergent);
            }
        
            if (guards.Life == guards.Maxlife)
            {
                Console.WriteLine("It is uninjured");
            }

            if (guards.Life < guards.Maxlife * .25 && guards.Life > 0)
            {
                Console.WriteLine("It is near death");
            }

      


        }





    }
}
   