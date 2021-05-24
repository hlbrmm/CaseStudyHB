namespace MarsRover.Models
{
    /// <summary>Plateau Map</summary>
    public class Map : Coordinates
    {
        public Map(int x, int y)
        {
            this.XCoordinate = x;
            this.YCoordinate = y;
        }
    }
}
