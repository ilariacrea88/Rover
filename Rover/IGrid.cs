using System.Collections.Generic;

public interface IGrid
{
    //puoi istanziarla con x max, y max e calcola automaticamnte l'area 
    // devi passargli un generatore di ostacoli
    // can be implemented also a grid without obstacle point 
    int Xmax { get; set; }
    int Ymax { get; set; }
    List<Obstacle> Obstacles{get;}

//List<Obstacle> GridObstacles(); 

}
