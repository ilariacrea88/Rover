public class RoverMars : IRover
{
    Point position = new Point(0, 0);
    char direction = 'N'; //default
    public RoverMars(char direction = 'N')
    {
        this.direction = direction;
    }
    public Point Position
    {
        get
        {
            return position;
        }
        set
        {
            position = value;
        }
    }
    public char Direction
    {
        get
        {
            return direction;
        }
        set {
            direction = value;
        }
    }
}
