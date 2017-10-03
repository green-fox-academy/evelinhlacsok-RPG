using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;


namespace RPGGame
{
    class Tile
    {
        public static void DrawTile(FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;
            for (int i = 1; i <= 10; i++)
            {
                y = i * 50;
                for (int j = 1; j <= 10; j++)
                {
                    x = j * 50;
                    foxDraw.AddImage("./Assets/floor.png", x, y);

                }
            }
            foxDraw.AddImage("./Assets/hero-down.png", 50, 50);
        }
    }
}
