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
           
            foxDraw.AddImage("./Assets/wall.png", 200, 50);
            foxDraw.AddImage("./Assets/wall.png", 200, 100);
            foxDraw.AddImage("./Assets/wall.png", 200, 150);
            foxDraw.AddImage("./Assets/wall.png", 150, 150);
            foxDraw.AddImage("./Assets/wall.png", 100, 150);

            foxDraw.AddImage("./Assets/wall.png", 300, 50);
            foxDraw.AddImage("./Assets/wall.png", 300, 100);
            foxDraw.AddImage("./Assets/wall.png", 300, 150);
            foxDraw.AddImage("./Assets/wall.png", 300, 200);
            foxDraw.AddImage("./Assets/wall.png", 300, 250);
            foxDraw.AddImage("./Assets/wall.png", 350, 250);
            foxDraw.AddImage("./Assets/wall.png", 400, 250);
            foxDraw.AddImage("./Assets/wall.png", 450, 250);
            foxDraw.AddImage("./Assets/wall.png", 450, 300);
            foxDraw.AddImage("./Assets/wall.png", 450, 350);
            foxDraw.AddImage("./Assets/wall.png", 450, 400);
            foxDraw.AddImage("./Assets/wall.png", 450, 450);

            foxDraw.AddImage("./Assets/wall.png", 400, 100);
            foxDraw.AddImage("./Assets/wall.png", 450, 100);
            foxDraw.AddImage("./Assets/wall.png", 400, 150);
            foxDraw.AddImage("./Assets/wall.png", 450, 150);

            foxDraw.AddImage("./Assets/wall.png", 50, 250);
            foxDraw.AddImage("./Assets/wall.png", 100, 250);
            foxDraw.AddImage("./Assets/wall.png", 150, 250);
            foxDraw.AddImage("./Assets/wall.png", 200, 250);
            
        }
    }
}
