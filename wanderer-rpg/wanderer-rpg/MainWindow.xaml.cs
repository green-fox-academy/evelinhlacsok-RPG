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
            Tile.DrawTile(foxDraw);
            Hero.SetHero(foxDraw);
            Hero.MoveLeft(foxDraw);
        }
        
        public void WindowKeyDown(object sender, KeyEventArgs e)
        {
            var foxDraw = new FoxDraw(canvas);
            if (e.Key == Key.Left)
            {
                Hero.MoveLeft(foxDraw);
            }

            if (e.Key == Key.Right)
            {
                Hero.MoveRight(foxDraw);
            }

            if (e.Key == Key.Down)
            {
                Console.WriteLine("Go down!");
            }

            if (e.Key == Key.Up)
            {
                Console.WriteLine("Go up!");
            }
        }
    }
}
