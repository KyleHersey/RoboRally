using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboRally
{
    public class UserPlayer
    {
        Robot rob;
        List<MovementCard> movementCards;

        public UserPlayer(Robot r)
        {
            rob = r;
        }

        public void GetDealt(List<MovementCard> l){
            movementCards = l;
        }

        public MovementCard getMovementCard(int i)
        {
            if (i >= movementCards.Count)
            {
                return null;
            }
            return movementCards[i];
        }
    }
}
