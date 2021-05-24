using MarsRover.Models;

namespace MarsRover.Manager
{
    interface IRoverManager
    {
        void MoveRover(Rover rover, Map map, string path);
        bool CanRoverMove(int mapBorder, int roverCoordinate);
        string GetPositionOfRover(Rover rover);
    }
}
