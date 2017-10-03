using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPGGame
{
    class Hero
    {
        public static void DrawHero(FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;

            foxDraw.AddImage("./Assets/hero-down.png", 50, 50);
        }
    }
}
