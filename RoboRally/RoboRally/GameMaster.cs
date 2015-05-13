using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboRally
{
    public class GameMaster
    {
        MainWindow mWindow;
        Deck movementDeck;
        UserPlayer thePlayer;
        bool gameOver;
        bool readyClick;

        public GameMaster(MainWindow window)
        {
            mWindow = window;
            movementDeck = new Deck();
            thePlayer = new UserPlayer(new Robot(2, 2, false, direction.UP));
            gameOver = false;
        }

        public void startGame()
        {
            prepareForTurn();
        }

        public void prepareForTurn()
        {
            movementDeck.Shuffle();
            dealCards();
        }

        public void dealCards()
        {
            thePlayer.GetDealt(movementDeck.DealCards(9));
            mWindow.showCardChoices(thePlayer);
            readyClick = true;
        }

        //method called by routed event indicating that the player clicked
            //calls perform moves

        public void performMoves()
        {
            List<MovementCard> cardList = mWindow.getChosenCards();

        }
    }
}
