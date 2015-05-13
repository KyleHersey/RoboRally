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
        GameMaster gm;

        public MainWindow()
        {
            InitializeComponent();
            populateBoards();

            gm = new GameMaster(this);
            gm.startGame();
        }

        public List<MovementCard> getChosenCards()
        {
            List<MovementCard> chosenCards = new List<MovementCard>();
            chosenCards.Add(playArea.Card0.loadedCard);
            chosenCards.Add(playArea.Card1.loadedCard);
            chosenCards.Add(playArea.Card2.loadedCard);
            chosenCards.Add(playArea.Card3.loadedCard);
            chosenCards.Add(playArea.Card4.loadedCard);
            return chosenCards;
        }

        public void showCardChoices(UserPlayer thePlayer)
        {
            playArea.choice0.setCard(thePlayer.getMovementCard(0));
            playArea.choice1.setCard(thePlayer.getMovementCard(1));
            playArea.choice2.setCard(thePlayer.getMovementCard(2));
            playArea.choice3.setCard(thePlayer.getMovementCard(3));
            playArea.choice4.setCard(thePlayer.getMovementCard(4));
            playArea.choice5.setCard(thePlayer.getMovementCard(5));
            playArea.choice6.setCard(thePlayer.getMovementCard(6));
            playArea.choice7.setCard(thePlayer.getMovementCard(7));
            playArea.choice8.setCard(thePlayer.getMovementCard(8));
        }

        public void populateBoards()
        {
                Board0.PopulateBoard();
        }

        private void ClickedReady(object sender, RoutedEventArgs e)
        {
            gm.userClickedReady();
        }
    }
}
