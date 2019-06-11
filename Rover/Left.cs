namespace Rover
{
    public class Left : Command
    {
        public override void MoveFromEstDirection(IRover rover, IGrid grid)
        {
            rover.Direction = 'N';
        }

        public override void MoveFromNordDirection(IRover rover, IGrid grid)
        {
            rover.Direction = 'O';
        }

        public override void MoveFromOvestDirection(IRover rover, IGrid grid)
        {
            rover.Direction = 'S';
        }

        public override void MoveFromSudDirection(IRover rover, IGrid grid)
        {
            rover.Direction = 'E';
        }
    }
}
