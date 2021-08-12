using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public abstract class Characters
    {
        //field
        private int _life;

        //properties
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Block { get; set; }
        public int Maxlife { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                _life = value > Maxlife ? Maxlife : value;
            }//end set
        }//end life

        //ctor not neccessary but eliminates duplication of code in other classes

        public Characters(string name, int attack, int block, int life, int maxlife)
        {
            Maxlife = maxlife;
            Name = name;
            Attack = attack;
            Block = block;
            Life = life;
        }

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcAttack()
        {
            return Attack;
        }


        public abstract int CalcDamage();
        //Because we don't define the default functionality we use a method stub with no body.

    }
}
