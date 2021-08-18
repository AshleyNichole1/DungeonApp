using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Weapon
    {
        private int _minDamage;
        public string Name { get; set; }
        public int BonusHitChance { get; set; }

        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }

        }

        public Weapon(string name, int bonusHitChance, int minDamage, int maxDamage)
        {
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;

            MinDamage = minDamage;
        }

        public override string ToString()
        {
            return string.Format($"{Name}\nDamage: {MinDamage} to {MaxDamage}\n" +
                $"Hit Modifier: {BonusHitChance}\n");
        }

        public Weapon() { }
    }
}
