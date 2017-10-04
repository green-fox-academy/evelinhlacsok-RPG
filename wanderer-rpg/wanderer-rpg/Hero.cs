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
            XCoord -= 50;
            foxDraw.AddImage(pathheroleft, XCoord, YCoord);
        }
        public static void MoveRight(FoxDraw foxDraw)
        {
            XCoord += 50;
            foxDraw.AddImage(pathheroright, XCoord, YCoord);
        }
        public static void MoveUp(FoxDraw foxDraw)
        {
            YCoord -= 50;
            foxDraw.AddImage(patheroup, XCoord, YCoord);
        }
        public static void MoveDown(FoxDraw foxDraw)
        {
            YCoord += 50;
            foxDraw.AddImage(pathherodown, XCoord, YCoord);
        }

    }
}
