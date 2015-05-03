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
        }

        public void updateBoard(Robot rob)
        {
            int row = Convert.ToInt32(rob.coordX);
            int column = Convert.ToInt32(rob.coordY);
           
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
