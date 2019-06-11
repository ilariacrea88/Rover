public interface ICommand
{
    //for each direction 
    void MoveFromNordDirection(IRover rover, IGrid grid);//pass rover for the actual position of rover, the point back is the ipothetical new position of the rover
    //after all controls
    void MoveFromSudDirection(IRover rover,IGrid grid);
    void MoveFromOvestDirection(IRover rover, IGrid grid);
    void MoveFromEstDirection(IRover rover, IGrid grid);
}
