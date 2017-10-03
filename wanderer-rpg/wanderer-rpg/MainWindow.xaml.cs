using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using GreenFox;
using System.Windows.Media;

namespace RPGGame
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
           // foxDraw.AddImage("./Assets/floor.png", 0, 0);
            DrawTile();
        }
        public void DrawTile()
        {
            var foxDraw = new FoxDraw(canvas);
            int x = 50;
            int y = 50;
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    foxDraw.AddImage("./Assets/floor.png", 0, 0);
                }
            }

        }
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                Console.WriteLine("To the left!");
            }

            if (e.Key == Key.Right)
            {
                Console.WriteLine("To the right!");
            }
        }
    }
}
