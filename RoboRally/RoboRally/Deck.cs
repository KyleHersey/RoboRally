using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboRally
{
    class Deck
    {
        List<MovementCard> movementCardList;

        public Deck()
        {
            movementCardList = new List<MovementCard>();

            for (int i = 10; i <= 60; i += 10)
            {
                movementCardList.Add(new MovementCard(i, moveCard.uTurn));
            }
            for (int i = 70; i <= 410; i += 20)
            {
                movementCardList.Add(new MovementCard(i, moveCard.rotateLeft));
            }
            for (int i = 80; i <= 420; i += 20)
            {
                movementCardList.Add(new MovementCard(i, moveCard.rotateRight));
            }
            for (int i = 430; i <= 480; i += 10)
            {
                movementCardList.Add(new MovementCard(i, moveCard.backUp));
            }
            for (int i = 490; i <= 660; i += 10)
            {
                movementCardList.Add(new MovementCard(i, moveCard.move1));
            }
            for (int i = 670; i <= 780; i += 10)
            {
                movementCardList.Add(new MovementCard(i, moveCard.move2));
            }
            for (int i = 790; i <= 840; i += 10)
            {
                movementCardList.Add(new MovementCard(i, moveCard.move3));
            }
        }

        public void shuffle()
        {
            List<MovementCard> temp = new List<MovementCard>();
            Random rand = new Random();

            while (movementCardList.Count > 0)
            {
                int index = rand.Next(0, movementCardList.Count);
                temp.Add(movementCardList[index]);
                movementCardList.RemoveAt(index);
            }

            movementCardList = temp;
        }
    }
}
