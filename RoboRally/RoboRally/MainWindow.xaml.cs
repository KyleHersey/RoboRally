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
        UserPlayer thePlayer;

        public MainWindow()
        {
            InitializeComponent();
            populateBoards();

            bool gameOver = false;

            movementDeck = new Deck();

            thePlayer = new UserPlayer(new Robot(2,2,false, direction.UP));

            //while (!gameOver)
            //{
                gameOver = doTurn();
            //}
        }

        public bool doTurn()
        {
            bool gameOver = false;
            movementDeck.Shuffle();

            //deal cards
            thePlayer.GetDealt(movementDeck.DealCards(9));

            //update gui with cards
            playArea.choice0.setCard(thePlayer.getMovementCard(0));
            playArea.choice1.setCard(thePlayer.getMovementCard(1));
            playArea.choice2.setCard(thePlayer.getMovementCard(2));
            playArea.choice3.setCard(thePlayer.getMovementCard(3));
            playArea.choice4.setCard(thePlayer.getMovementCard(4));
            playArea.choice5.setCard(thePlayer.getMovementCard(5));
            playArea.choice6.setCard(thePlayer.getMovementCard(6));
            playArea.choice7.setCard(thePlayer.getMovementCard(7));
            playArea.choice8.setCard(thePlayer.getMovementCard(8));

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
