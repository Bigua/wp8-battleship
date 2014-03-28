using Battleship.Codes;
using Microsoft.Phone.Controls;
using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

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
            bool[] test = jogo.Shoot(Grid.GetRow(r), Grid.GetColumn(r));
            if (test[0])
            {
                this.efectiveShoots(r);
                if (test[1])
                {
                    this.veryEfectiveShoot();
                    this.testEnd();
                }
            }
            else
            {
                this.countShoots();
            }
        }

        public void efectiveShoots(Rectangle rect)
        {
            rect.Fill = new SolidColorBrush(Colors.Red);
            HitCount.Text = Convert.ToString(Convert.ToInt32(HitCount.Text) + 1);
            ShootCount.Text = Convert.ToString(Convert.ToInt32(ShootCount.Text) + 1);

            this.setNews("It's super effective!");

        }

        public void veryEfectiveShoot()
        {
            SinkedBoats.Text = Convert.ToString(Convert.ToInt32(SinkedBoats.Text) + 1);
            this.setNews("Navio Afundado!!");
        }

        public void testEnd()
        {
            if (Convert.ToInt32(SinkedBoats.Text) == 11)
            {
                var a = ContentPanel.Children;

                foreach (var item in a)
                {
                    Rectangle r = (Rectangle)item;
                    r.Fill = new SolidColorBrush(Colors.Green);
                }
                this.setNews("Parabéns, você zerou!");
            }
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