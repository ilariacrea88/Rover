using System.Collections.Generic;

public interface IObstacleGenerator
{
    List<Obstacle> ObstacleGen(int x,int y);
}
