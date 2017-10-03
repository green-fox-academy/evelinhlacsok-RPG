using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.IO;


namespace RPGGame
{
    class Tile
    {
        public static void DrawTile(FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    y = i * 50;
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        x = j * 50;
            //        foxDraw.AddImage("./Assets/floor.png", x, y);
            //    }
            // }

            StreamReader myReader = new StreamReader(@"\\Mac\Home\Documents\greenfox\evelinhlacsok-RPG\wanderer-rpg\wanderer-rpg\Assets\map.txt");
            string line = "";
            while (line != null)
            {
                line = myReader.ReadLine();
                y = y + 50;
                x = 0;
                if (line != null)
                {
                    string[] letters = line.Split(' ');
                    foreach (var letter in letters)
                    {
                        x = x + 50;
                        if (letter == "w")
                        {
                            foxDraw.AddImage("./Assets/wall.png", x, y);
                        }
                        else
                        {
                            foxDraw.AddImage("./Assets/floor.png", x, y);
                        }
                    }
                }
            }
        }
    }
}
