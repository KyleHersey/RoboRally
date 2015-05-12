using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboRally
{
    public enum moveCard {uTurn, rotateLeft, rotateRight, backUp, move1, move2, move3};
    public class MovementCard
    {
        public int priority;
        public moveCard movement;

        public MovementCard(int p, moveCard mc){
            movement = mc;
            priority = p;
        }
    }
}
