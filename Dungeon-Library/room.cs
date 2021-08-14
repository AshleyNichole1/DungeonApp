using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public class Room

    {
        public static string ChooseRoom()
        {
            string[] rooms =
           { "You enter the random red room and see ","You enter the random blue room and see","You enter the random purple room and see", "You enter the random orange room and see"};

            return rooms[new Random().Next(rooms.Length)];
        } 

    }
}



