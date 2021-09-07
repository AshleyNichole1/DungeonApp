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
           { "You enter a utility room and see","You enter the computer lab and see","You enter the control room and see", "You enter the basement and see"};

            return rooms[new Random().Next(rooms.Length)];
        } 

    }
}



