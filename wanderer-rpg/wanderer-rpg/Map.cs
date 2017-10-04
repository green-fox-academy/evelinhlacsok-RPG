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
            
            StreamReader myReader = new StreamReader(@"\\Mac\Home\Documents\greenfox\evelinhlacsok-RPG\wanderer-rpg\wanderer-rpg\Assets\map.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                y = y + 1;
                x = 0;
                if (line != null)
                {
                    string[] letters = line.Split(' ');
                    foreach (var letter in letters)
                    {
                        x = x + 1;
                        if (letter == "w")
                        {
                            matrix[x, y] = 1;
                            foxDraw.AddImage("./Assets/wall.png", x * 50, y * 50);
                        }
                        else
                        {
                            matrix[x, y] = 0;
                            foxDraw.AddImage("./Assets/floor.png", x * 50, y * 50);
                        }
                    }
                      
                }
            }
        }
    }
}
