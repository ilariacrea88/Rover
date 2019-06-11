using System;
using System.Collections.Generic;
/// <summary>
/// if the default constructor will be used the obstacle list will remains empty
/// </summary>
public class Grid : IGrid
{
    //needs a list of obstacle point, when declaring a grid you shell pass a Obstacle Generator 

    int xMax = 0;
    int yMax = 0;
   
    List<Obstacle> obstacles = new List<Obstacle>();

    public Grid(int xMax, int yMax, IObstacleGenerator generatorOfObstaclesPoint)
    {
        this.xMax = xMax;
        this.yMax = yMax;
        this.obstacles = generatorOfObstaclesPoint.ObstacleGen(this.xMax, this.Ymax);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Grid dimensions are: Xmax "+this.xMax.ToString()+" Ymax "+this.yMax.ToString());
       
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Obstacles are:");
        foreach (Obstacle obstacle in obstacles)
        {
            Console.WriteLine("X: "+obstacle.X.ToString()+" Y: "+obstacle.Y.ToString());
        }
        Console.ResetColor();
    }
    public int Xmax
    {
        get
        {
            return xMax;
        }
        set
        {
            if (value < 100)
            {
                xMax = value;
            }
            else
            {
                xMax = 0;
            }
        }
    }
    public int Ymax
    {
        get
        {
            return yMax;
        }
        set
        {
            if (value < 100)
            {
                yMax = value;
            }
            else
            {
                yMax = 0;
            }

        }
    }
    public List<Obstacle> Obstacles
    {
        get { return obstacles; }
    }
        
}
