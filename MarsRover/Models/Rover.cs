namespace MarsRover.Models
{
    /// <summary>Mars Rover Model</summary>
    public class Rover : Coordinates
    {
        public char Direction { get; set; }
        public Rover(int xCoordinateOfRover, int yCoordinateOfRover, char Direction)
        {
            this.XCoordinate = xCoordinateOfRover;
            this.YCoordinate = yCoordinateOfRover;
            this.Direction = Direction;
        }
    }
}
