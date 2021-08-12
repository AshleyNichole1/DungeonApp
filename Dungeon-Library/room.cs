using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class room

    {
        public static string ChooseRoom()
        {
            string[] rooms =
           { "Random room red","Random room blue","Random room purple", "Random room orange"};

            return rooms[new Random().Next(rooms.Length)];
        } 

    }
}



