using MarsRover.Models;
using System;

namespace MarsRover.Manager
{
    public class RoverManager : IRoverManager
    {
        /// <summary>
        /// Moves Rover by Specified Command
        /// </summary>
        /// <param name="rover"></param>
        /// <param name="map"></param>
        /// <param name="path"></param>
        public void MoveRover(Rover rover, Map map, string path)
        {
            char[] commands = path.ToCharArray();

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == Constants.TURN_LEFT)
                {
                    TurnLeft(rover);
                }
                else if (commands[i] == Constants.TURN_RIGHT)
                {
                    TurnRight(rover);
                }
                else if (commands[i] == Constants.MOVE)
                {
                    MoveForward(rover, map);
                }
            }
        }

        /// <summary>
        /// Turns head of rover to the left.
        /// </summary>
        /// <param name="rover"></param>
        private void TurnLeft(Rover rover)
        {
            if (rover.Direction == Constants.NORTH)
            {
                rover.Direction = Constants.WEST;
            }
            else if (rover.Direction == Constants.EAST)
            {
                rover.Direction = Constants.NORTH;
            }
            else if (rover.Direction == Constants.SOUTH)
            {
                rover.Direction = Constants.EAST;
            }
            else if (rover.Direction == Constants.WEST)
            {
                rover.Direction = Constants.SOUTH;
            }
        }

        /// <summary>
        /// Moves Rover to forward.
        /// </summary>
        /// <param name="rover"></param>
        /// <param name="map"></param>
        private void MoveForward(Rover rover, Map map)
        {
            if (rover.Direction == Constants.NORTH && CanRoverMove(map.YCoordinate, rover.YCoordinate))
            {
                rover.YCoordinate += 1;
            }
            else if (rover.Direction == Constants.EAST && CanRoverMove(map.XCoordinate, rover.XCoordinate))
            {
                rover.XCoordinate += 1;
            }
            else if (rover.Direction == Constants.SOUTH && CanRoverMove(map.YCoordinate, rover.YCoordinate))
            {
                rover.YCoordinate -= 1;
            }
            else if (rover.Direction == Constants.WEST && CanRoverMove(map.XCoordinate, rover.XCoordinate))
            {
                rover.XCoordinate -= 1;
            }
        }

        /// <summary>
        /// Turns head of rover to the right.
        /// </summary>
        /// <param name="rover"></param>
        private void TurnRight(Rover rover)
        {
            if (rover.Direction == Constants.NORTH)
            {
                rover.Direction = Constants.EAST;
            }
            else if (rover.Direction == Constants.EAST)
            {
                rover.Direction = Constants.SOUTH;
            }
            else if (rover.Direction == Constants.SOUTH)
            {
                rover.Direction = Constants.WEST;
            }
            else if (rover.Direction == Constants.WEST)
            {
                rover.Direction = Constants.NORTH;
            }
        }

        /// <summary>
        /// Checks rover can move.
        /// </summary>
        /// <param name="mapBorder"></param>
        /// <param name="roverCoordinate"></param>
        /// <returns></returns>
        public bool CanRoverMove(int mapBorder, int roverCoordinate)
        {
            return true && mapBorder > roverCoordinate;
        }

        /// <summary>
        /// Gets current position of rover's.
        /// </summary>
        /// <param name="rover"></param>
        /// <returns></returns>
        public string GetPositionOfRover(Rover rover)
        {
            return String.Format("{0} {1} {2}", rover.XCoordinate, rover.YCoordinate, rover.Direction);
        }
    }
}
