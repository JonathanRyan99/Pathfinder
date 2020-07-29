using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using System.IO;

namespace Pathfinder
{
    class AiBotSimple : AiBotBase
    {
        public AiBotSimple(int x, int y) : base(x, y)
        {
        }

        protected override void ChooseNextGridLocation(Level level, Player plr)
        {
           //goal of movement: differnce between playerpos and botpos = 0

            Coord2 newPos;
            newPos = GridPosition;//stores newpos (coordinates) 
           
            int difX = GridPosition.X - plr.GridPosition.X;
            int difY = GridPosition.Y - plr.GridPosition.Y;

            //difernce is postivive
            if (difX < 0)
                newPos.X += 1;

            else if (difY < 0)
                newPos.Y += 1;

            //the difference is negative value
            if (difX > 0)
                newPos.X -= 1;

            else if (difY > 0)
                newPos.Y -= 1;

            SetNextGridPosition(newPos, level);

        }
    }
}


