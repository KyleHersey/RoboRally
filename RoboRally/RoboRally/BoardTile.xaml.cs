using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RoboRally
{
    /// <summary>
    /// Interaction logic for BoardTile.xaml
    /// </summary>
    public partial class BoardTile : UserControl
    {
        Image robotImage;
        public BoardTile()
        {
            InitializeComponent();
        }

        public void removeRobot(){
            try{
                tile.Children.Remove(robotImage);
            }
            catch { }
        }

        public void drawRobot(Robot rob)
        {
            robotImage = new Image();
            robotImage.Source = new BitmapImage(new Uri(@"C:\Users\Kyle\Documents\GitHub\RoboRally\RoboRally\RoboRally\RobotImage.png"));
            robotImage.Stretch = Stretch.Fill;
            tile.Children.Add(robotImage);
        }
    }
}
