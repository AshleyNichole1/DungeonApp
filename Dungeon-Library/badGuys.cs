using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class BadGuys : Characters
    {

        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }//end set }
        }

        public BadGuys(string name, int attack, int block, int life, int maxLife, int maxDamage, string description, int minDamage)
            : base(name, attack, block, life, maxLife)

        {
            Maxlife = maxLife;
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;
            Name = name;
            Attack = attack;
            Block = block;
            Life = life;

        }
        public override string ToString()
        {

            return string.Format("Name: " + Name + "\nDescriprion: " + Description + "\nLife: " + Life + "\nMaxLife: " + Maxlife
                 + "\nAttack: " + Attack + "\nBlock: " + Block + "\n");

        }

        public override int CalcDamage()
        {
            Random rand = new Random();

            int damage = rand.Next(MinDamage, MaxDamage + 1);
            return damage;
        }


    }
}
