using MarsRover.Manager;
using MarsRover.Models;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Plateau Map
            Map map = new Map(5, 5);
            RoverManager roverManager = new RoverManager();

            //Initialize Rover1 Position
            Rover rover1 = new Rover(1, 2, 'N');
            roverManager.MoveRover(rover1, map, "LMLMLMLMM");

            //Initialize Rover2 Position
            Rover rover2 = new Rover(3, 3, 'E');
            roverManager.MoveRover(rover2, map, "MMRMMRMRRM");

            //Gets positions of rovers.
            string exampleOutput1 = roverManager.GetPositionOfRover(rover1);
            string exampleOutput2 = roverManager.GetPositionOfRover(rover2);

            Console.WriteLine(exampleOutput1);
            Console.WriteLine(exampleOutput2);
        }
    }
}
