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
    /// Interaction logic for Board.xaml
    /// </summary>
    public partial class Board : UserControl
    {
        public Board()
        {
            InitializeComponent();
        }

        public void PopulateBoard(){
            foreach (BoardRow boardrow in rows.Children)
            {
                foreach (Grid grid in boardrow.columns.Children)
                {
                    Image image = new Image();
                    image.Source = new BitmapImage(new Uri(@"C:\Users\Kyle\Documents\GitHub\RoboRally\RoboRally\RoboRally\FloorTile.png"));
                    image.Margin = new Thickness(0, 0, 0, 0);
                    image.Stretch = Stretch.Fill;
                    grid.Children.Add(image);
                }
            }
        }
    }
}
