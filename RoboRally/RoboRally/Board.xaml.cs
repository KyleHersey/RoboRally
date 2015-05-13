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

        public BoardRow getRow(int i)
        {
            switch (i)
            {
                case 0: return Row0;
                case 1: return Row1;
                case 2: return Row2;
                case 3: return Row3;
                case 4: return Row4;
                case 5: return Row5;
                case 6: return Row6;
                case 7: return Row7;
                case 8: return Row8;
                case 9: return Row9;
                case 10: return Row10;
                case 11: return Row11;
                default: return null;
            }
        }

        public void robotRegisterPhase(Robot rob, MovementCard mc){

        }

        public void removeRobot(Robot rob)
        {
            getRow(rob.coordY).getColumn(rob.coordX).removeRobot();
        }

        public void drawRobot(Robot rob)
        {
            getRow(rob.coordY).getColumn(rob.coordX).drawRobot(rob);
        }

        public void PopulateBoard(){
            foreach (BoardRow boardrow in rows.Children)
            {
                foreach (BoardTile boardtile in boardrow.columns.Children)
                {
                    Image image = new Image();
                    image.Source = new BitmapImage(new Uri(@"C:\Users\Kyle\Documents\GitHub\RoboRally\RoboRally\RoboRally\FloorTile.png"));
                    image.Stretch = Stretch.Fill;
                    boardtile.tile.Children.Add(image);
                }
            }
        }
    }
}
