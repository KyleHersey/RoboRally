using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboRally
{
    public class GameMaster
    {
        public readonly int maxRegister = 4;

        MainWindow mWindow;
        Deck movementDeck;
        UserPlayer thePlayer;
        bool gameOver;
        bool readyClick;
        int register;

        public GameMaster(MainWindow window)
        {
            mWindow = window;
            movementDeck = new Deck();
            thePlayer = new UserPlayer(new Robot(2, 2, false, direction.UP));
            gameOver = false;
            register = 0;
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

        public void userClickedReady()
        {
            if (readyClick)
            {
                readyClick = false;
                performMoves();
            }
        }

        public void performMoves()
        {
            doRegister(register);
        }

        public void doRegister(int r)
        {
            MovementCard mc = null;
            switch (r)
            {
                case 0: mc = mWindow.playArea.Card0.loadedCard; break;
                case 1: mc = mWindow.playArea.Card1.loadedCard; break;
                case 2: mc = mWindow.playArea.Card2.loadedCard; break;
                case 3: mc = mWindow.playArea.Card3.loadedCard; break;
                case 4: mc = mWindow.playArea.Card4.loadedCard; break;
            }

            mWindow.Board0.robotRegisterPhase(thePlayer.rob, mc);
            register++;

            if (register > maxRegister)
            {
                cleanup();
            }
            else
            {
                doRegister(register);
            }
        }

        public void cleanup()
        {
            movementDeck = new Deck();
        }
    }
}
