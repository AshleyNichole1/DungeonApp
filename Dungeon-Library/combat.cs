using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class combat
    {
        public static void Attack(Characters attacker, Characters defender)
        {
            //Use a dice roll from 1-100 to use as a basis to determine if the attacker hits:
            int diceroll = new Random().Next(1, 101);
            //The sleep() allows us to pause the execution of code for a defined number
            //of milliseconds:
            System.Threading.Thread.Sleep(35);
            if (diceroll <= attacker.CalcAttack() - defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();

            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }

        }
        public static void Battle(Player divergent, badGuys guards)
        {
            Attack(divergent, guards);
            if (guards.Life > 0)
            {
                Attack(guards, divergent);
            }
        }
    }
}
