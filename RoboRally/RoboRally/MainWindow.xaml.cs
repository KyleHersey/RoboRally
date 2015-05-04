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
        Deck movementDeck;

        public MainWindow()
        {
            InitializeComponent();
            populateBoards();

            bool gameOver = false;

            movementDeck = new Deck();

            while (!gameOver)
            {
                gameOver = doTurn();
            }
        }

        public bool doTurn()
        {
            bool gameOver = false;
            movementDeck.shuffle();
            //deal cards
            //players select moves at this time
            //get player moves
            //perform moves
            //cleanup

            return gameOver;
        }

        public void dealCards()
        {

        }

        public void populateBoards()
        {
                Board0.PopulateBoard();
        }
    }
}
