using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RoboRally
{
    public enum direction { UP, RIGHT, DOWN, LEFT };
    public class Robot
    {
        public int damage;

        public int coordX;
        public int coordY;

        public int checkpointX;
        public int checkpointY;

        public direction dir;

        public Robot(int startX, int startY, bool onDeath, direction inputDirection)
        {

            dir = inputDirection;

            coordX = startX;
            coordY = startY;

            checkpointX = startX;
            checkpointY = startY;

            if (onDeath)
            {
                damage = 2;
            }
            else
            {
                damage = 0;
            }
        }

        public void turnLeft()
        {
            if (dir == direction.UP)
            {
                dir = direction.LEFT;
            }
            else
            {
                dir--;
            }
        }

        public void turnRight()
        {
            if (dir == direction.LEFT)
            {
                dir = direction.UP;
            }
            else
            {
                dir++;
            }
        }

        public void uTurn()
        {
            switch (dir)
            {
                case direction.UP:
                    dir = direction.DOWN;
                    break;
                case direction.RIGHT:
                    dir = direction.LEFT;
                    break;
                case direction.DOWN:
                    dir = direction.UP;
                    break;
                case direction.LEFT:
                    dir = direction.RIGHT;
                    break;
            }
        }

        public void moveForward()
        {
            //Console.WriteLine(dir);
            switch (dir)
            {
                case direction.UP:
                    coordY--;
                    break;
                case direction.RIGHT:
                    coordX++;
                    break;
                case direction.DOWN:
                    coordY++;
                    break;
                case direction.LEFT:
                    coordX--;
                    break;
            }
        }
    }
}
