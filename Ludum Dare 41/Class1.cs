using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Ludum_Dare_41
{
    public class Room
    {
        public Coordinate[] exitCoord;
        public int[] exitRoom;
        public Coordinate[] walkableCoord;
        public Image roomImg;

        public Room(Coordinate[] exitCo, int[] exitRm, Coordinate[] wlkCo, Image rmImg)
        {
            exitCoord = exitCo;
            exitRoom = exitRm;
            walkableCoord = wlkCo;
            roomImg = rmImg;
        }
    }

    public class Key
    {
        public string color;
        public Coordinate location;

        public Key(string color, Coordinate location)
        {
            this.color = color;
            this.location = location;
        }
    }

    public class Player
    {

        public Coordinate location;

        public Player(Coordinate location)
        {
            this.location = location;
        }

    }

    public class Coordinate
    {
        public int x;
        public int y;

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
