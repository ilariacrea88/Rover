namespace Rover.UnitTests
{
    public class FakeLeftCommand : Command
    {
       public  string Fake{ get; set; }


        public override void MoveFromEstDirection(IRover rover, IGrid grid)
        {
            Fake = "Left.MoveFromEstDirection";
        }

        public override void MoveFromNordDirection(IRover rover, IGrid grid)
        {
            Fake = "Left.MoveFromNordDirection";
        }

        public override void MoveFromOvestDirection(IRover rover, IGrid grid)
        {
            Fake = "Left.MoveFromOvestDirection";
        }

        public override void MoveFromSudDirection(IRover rover, IGrid grid)
        {
            Fake = "Left.MoveFromSudDirection";
        }
    }
}
