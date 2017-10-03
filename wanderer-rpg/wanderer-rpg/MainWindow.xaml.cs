using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using GreenFox;
using System.Windows.Media;
using System.Windows.Input;

namespace RPGGame
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawTile();
        }
        public void DrawTile()
        {
            var foxDraw = new FoxDraw(canvas);
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
