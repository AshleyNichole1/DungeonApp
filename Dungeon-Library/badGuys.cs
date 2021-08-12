using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class badGuys : Characters
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

        public badGuys(string name, int hitChance, int block, int life, int maxLife, int maxDamage, string description, int minDamage)
            : base(name, hitChance, block, life, maxLife)

        {
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;
        }
        public override string ToString()
        {

            return string.Format($"{Name}\n{Description}\n" +
              $"{(Life == Maxlife ? "You've done damage!" : Life <= Maxlife * .25 ? "The battle is almost won!" : "You've done damage")}");
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
    }
}
