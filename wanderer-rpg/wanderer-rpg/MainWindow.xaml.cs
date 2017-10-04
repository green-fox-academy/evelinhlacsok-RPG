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
        FoxDraw foxDraw;
        Map map;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            Map.DrawMap(foxDraw);
            map = new Map();
            Hero.SetHero(foxDraw);
        }
        
        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            Map.DrawMap(foxDraw);
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
                Hero.MoveDown(foxDraw);
            }

            if (e.Key == Key.Up)
            {
                Hero.MoveUp(foxDraw);
            }
        }
    }
}
