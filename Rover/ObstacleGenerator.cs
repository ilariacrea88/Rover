using System.Collections.Generic;
using System;
using System.Linq;
/// <summary>
///this obstacle generator warks well if maximum number of obstacle point shell is about number of possible grid point divided by two,
///if the argument passed exceede this value an exception will be thrown 
/// </summary>

public class ObstacleGenerator : IObstacleGenerator
{
    int numberOfObstacles = 0;
    public ObstacleGenerator(int obstaclesNumber)
    {
        this.numberOfObstacles = obstaclesNumber;
    }
    public List<Obstacle> ObstacleGen(int xmax, int ymax)
    {
        var myObstacle = new List<Obstacle>();
        int x;
        int y;
        int count = 0;
        var rnd = new Random();
        //grid point number=(xmax+1)*(ymax+1) because we shell consider also the coord (x=0 and y=0)
        if (this.numberOfObstacles > (((xmax + 1) * (ymax + 1))/2))
        {
            throw new Exception("number of obstacle point shell be maximum about half number of grid point ");
        }
        while (count <this.numberOfObstacles)
        {
            x = rnd.Next(0,xmax);
            y = rnd.Next(0,ymax);
            
            var obstacle = new Obstacle(x, y);

            //to make sure the point (0,0) is not an obstacle point and to be sure to dont't have duplicated obstacles point

            if ((!(myObstacle.Any(o => o.Equals(obstacle)))) && (obstacle.X!=0||obstacle.Y!=0))
            {
                myObstacle.Add(obstacle);
                count++;// only if an obstacle is added to list
            }
        }
       
        return myObstacle;
    }
}
