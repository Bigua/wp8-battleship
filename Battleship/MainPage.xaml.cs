using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Battleship.Resources;
using System.Diagnostics;
using System.Windows.Shapes;
using Battleship.Codes;
using System.Windows.Media;
using System.Reflection;

namespace Battleship
{
    public partial class MainPage : PhoneApplicationPage
    {
        Game jogo;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
            jogo = new Game();
        }

        public void fire(object sender, EventArgs e)
        {
            Rectangle r = (Rectangle)sender;
            if (jogo.Shoot(Grid.GetRow(r), Grid.GetColumn(r)))
            {
                this.efectiveShoots(r);
            }
            else
            {
                this.countShoots();
            }
        }

        public void efectiveShoots(Rectangle rect)
        {
            rect.Fill = new SolidColorBrush(Colors.Red);
            HitCount.Text = Convert.ToString(Convert.ToInt32(ShootCount.Text) + 1);
            this.setNews("It's super effective!");
        }

        public void setNews(String news)
        {
            newsBar.Text = news;
        }

        public void countShoots()
        {
            ShootCount.Text = Convert.ToString(Convert.ToInt32(ShootCount.Text) + 1);
            this.setNews("Água!!!=(");
        }
    }
}