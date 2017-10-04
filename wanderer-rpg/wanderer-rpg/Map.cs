using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.IO;


namespace RPGGame
{
    class Map
    {
        static int[,] matrix = new int[10, 10];
       
        public static void DrawMap(FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;
            int x2 = 0;
            int y2 = 0;

            StreamReader myReader = new StreamReader(@"\\Mac\Home\Documents\greenfox\evelinhlacsok-RPG\wanderer-rpg\wanderer-rpg\Assets\map.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                y = y + 50;
                y2 = y2 + 1;
                x = 0;
                x2 = 0;
                if (line != null)
                {
                    string[] letters = line.Split(' ');
                    foreach (var letter in letters)
                    {
                        x = x + 50;
                        x2 = x2 + 1;
                        if (letter == "w")
                        {
                            foxDraw.AddImage("./Assets/wall.png", x, y);
                            matrix[x2, y2] = 1;
                        }
                        else
                        {
                          //  matrix[x/50, y/50] = 0;
                            foxDraw.AddImage("./Assets/floor.png", x, y);
                        }
                    }
                }
            }
        }
    }
}
