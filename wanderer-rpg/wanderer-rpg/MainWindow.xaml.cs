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
            Hero.DrawHero(foxDraw);
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
