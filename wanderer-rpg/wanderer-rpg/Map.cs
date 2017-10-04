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
        public static void DrawMap(FoxDraw foxDraw)
        {
            int x = 0;
            int y = 0;
            
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
