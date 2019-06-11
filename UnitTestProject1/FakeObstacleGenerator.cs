using System.Collections.Generic;

namespace Rover.UnitTests
{
    /*the obstacle generator has a logic a bit more complicated  respect to grid and rover so it is the only one which 
     i provide a fake one for the test
    */
    public class FakeObstacleGenerator : IObstacleGenerator
    {

        List<Obstacle> IObstacleGenerator.ObstacleGen(int x, int y)
        {
            return new List<Obstacle>() { new Obstacle(2, 2) };
        }
    }
}
