using System;
using System.Linq;
namespace Rover
{
    public abstract class Command:ICommand
    {
        public abstract void MoveFromNordDirection(IRover rover, IGrid grid);
        public abstract void MoveFromSudDirection(IRover rover, IGrid grid);
        public abstract void MoveFromOvestDirection(IRover rover, IGrid grid);
        public abstract void MoveFromEstDirection(IRover rover, IGrid grid);
        public void CheckIfObstacle(Point p, IGrid grid)
        {
            Obstacle ipotheticalObstacle = new Obstacle(p.X, p.Y);
            if (grid.Obstacles.Any(element => element.Equals(ipotheticalObstacle)))
            {
                throw new Exception("The point is an obstacle point");
            }
        }

    }
}
