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
            // string path = ("./Assets/map.txt");
            // ReadFile(path);

            StreamReader myReader = new StreamReader(@"\\Mac\Home\Documents\greenfox\evelinhlacsok-RPG\wanderer-rpg\wanderer-rpg\Assets\map.txt");
            string line = "";
            while (line != null)
            {
                line = myReader.ReadLines();
                if (line != null)
                {
                    string[] letters = line.Split(' ');
                    foreach (var letter in letters)
                    {
                        if (letter == "f")
                        {
                            foxDraw.AddImage("./Assets/floor.png", x, y);
                        }
                        else
                        {
                            foxDraw.AddImage("./Assets/wall.png", x, y);
                        }

                    }
                }
            }


            //foxDraw.AddImage("./Assets/wall.png", 200, 50);
            //foxDraw.AddImage("./Assets/wall.png", 200, 100);
            //foxDraw.AddImage("./Assets/wall.png", 200, 150);
            //foxDraw.AddImage("./Assets/wall.png", 150, 150);
            //foxDraw.AddImage("./Assets/wall.png", 100, 150);
            
        }
        //static void ReadFile(string path)
        //{
        //    File.ReadAllText(path);
        //}
    }
}
