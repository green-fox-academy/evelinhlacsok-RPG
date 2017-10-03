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
        static string pathherodown = "./Assets/hero-down.png";
        static string pathheroleft = "./Assets/hero-left.png";
        static string pathheroright = "./Assets/hero-right.png";
        static string patheroup = "./Assets/hero-up.png";
        public static FoxDraw foxDraw;
        public static int XCoord = 50;
        public static int YCoord = 50;

        public static void SetHero(FoxDraw foxDraw)
        {
            Hero.foxDraw = foxDraw;
            foxDraw.AddImage(pathherodown, 50, 50);
        }
        public static void MoveLeft(FoxDraw foxDraw)
        {
            foxDraw.AddImage(pathheroleft, XCoord - 50, YCoord);
            XCoord -= 50;
        }
        public static void MoveRight(FoxDraw foxDraw)
        {
            foxDraw.AddImage(pathheroright, XCoord + 50, YCoord);
            XCoord += 50;
        }

    }
}
