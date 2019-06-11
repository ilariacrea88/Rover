using System;
using System.Linq;
namespace Rover
{
    public class Foreward : Command
    {
        public override void MoveFromOvestDirection(IRover rover, IGrid grid)
        {
            
            int? newPx = rover.Position.X - 1;
           
            
            if (newPx.Value>grid.Xmax)
            {
                newPx = 0;//may this case never occurs if you have the rover looking in Ovest direction
            }
            if (newPx.Value < 0)
            {
                newPx = grid.Xmax;
            }
            Point p = new Point(newPx, rover.Position.Y);

            CheckIfObstacle(p, grid);
            
            rover.Position = p;
            
        }

        public override void MoveFromEstDirection(IRover rover, IGrid grid)
        {

            int? newPx = rover.Position.X + 1;
           
           
            if (newPx.Value > grid.Xmax)
            {
                newPx = 0;
            }
            if (newPx.Value < 0)
            {
                newPx = grid.Xmax;
            }
            Point p = new Point(newPx, rover.Position.Y);

            CheckIfObstacle(p, grid);

            rover.Position = p;
            
        }
        public override void MoveFromNordDirection(IRover rover, IGrid grid)
        {
            int? newPy = rover.Position.Y + 1;
            
            if (newPy.Value > grid.Ymax)
            {
                newPy = 0;
            }
            if (newPy.Value < 0)
            {
                newPy = grid.Ymax;
            }

            Point p = new Point(rover.Position.X, newPy);
            
            CheckIfObstacle(p, grid);

            rover.Position = p;
          
        }
        public override void MoveFromSudDirection(IRover rover,IGrid grid)
        {
            int? newPy = rover.Position.Y - 1;
           
           
            if (newPy.Value > grid.Ymax)
            {
                newPy = 0;
            }
            if (newPy.Value < 0)
            {
                newPy = grid.Ymax;
            }

            Point p = new Point(rover.Position.X, newPy);

            CheckIfObstacle(p, grid);

            rover.Position = p;
           
        }
    }
}
