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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Robot rob;

        public MainWindow()
        {
            InitializeComponent();
            populateBoards();
            rob = new Robot(2, 2, false, direction.DOWN);

            this.KeyDown += new KeyEventHandler(MainWindow_KeyDown);
        }

        void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    rob.moveForward();
                    break;
                case Key.A:
                    rob.turnLeft();
                    break;
                case Key.D:
                    rob.turnRight();
                    break;
            }

            updateBoard(rob);
        }

        public void updateBoard(Robot rob)
        {
            int row = Convert.ToInt32(rob.coords.X);
            int column = Convert.ToInt32(rob.coords.Y);

           
        }

        public void populateBoards()
        {
            foreach (Board board in mainGrid.Children)
            {
                board.PopulateBoard();
            }
        }
    }
}
