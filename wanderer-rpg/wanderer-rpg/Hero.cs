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
        Map map = new Map();

        public static void SetHero(FoxDraw foxDraw)
        {
            Hero.foxDraw = foxDraw;
            foxDraw.AddImage(pathherodown, 50, 50);
        }

        public void TryToMove(FoxDraw foxDraw)
        {

        }

        public static void MoveLeft(FoxDraw foxDraw)
        {
            if (XCoord > 50)
            {
                XCoord -= 50;
            }
            foxDraw.AddImage(pathheroleft, XCoord, YCoord);
        }
        public static void MoveRight(FoxDraw foxDraw)
        {
            if (XCoord < 500)
            {
                XCoord += 50;
            }
            foxDraw.AddImage(pathheroright, XCoord, YCoord);
        }
        public static void MoveUp(FoxDraw foxDraw)
        {
            if (YCoord > 50)
            {
                YCoord -= 50;
            }
            foxDraw.AddImage(patheroup, XCoord, YCoord);
        }
        public static void MoveDown(FoxDraw foxDraw)
        {
            if (YCoord < 500)
            {
                YCoord += 50;
            }
            foxDraw.AddImage(pathherodown, XCoord, YCoord);
        }

    }
}
