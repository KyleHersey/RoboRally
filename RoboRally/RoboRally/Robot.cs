using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RoboRally
{
    public enum direction { UP, RIGHT, DOWN, LEFT };
    public class Robot
    {
        public int damage;
        public Point coords;
        public Point checkpointCoords;
        public direction dir;

        public Robot(int startX, int startY, bool onDeath, direction inputDirection)
        {

            dir = inputDirection;

            coords = new Point(startX, startY);
            checkpointCoords = new Point(startX, startY);

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
            switch (dir)
            {
                case direction.UP:
                    coords.Y--;
                    break;
                case direction.RIGHT:
                    coords.X++;
                    break;
                case direction.DOWN:
                    coords.Y++;
                    break;
                case direction.LEFT:
                    coords.X--;
                    break;
            }

            Console.WriteLine(coords);
        }
    }
}
