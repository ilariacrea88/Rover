namespace Rover.UnitTests
{
    public class FakeBackwardCommand : Command
    {
       public string Fake { get; set; }

        public override void MoveFromEstDirection(IRover rover, IGrid grid)
        {
            Fake = "Backward.MoveFromEstDirection";
        }

        public override void MoveFromNordDirection(IRover rover, IGrid grid)
        {
            Fake = "Backward.MoveFromNordDirection";
        }

        public override void MoveFromOvestDirection(IRover rover, IGrid grid)
        {
            Fake = "Backward.MoveFromOvestDirection";
        }

        public override void MoveFromSudDirection(IRover rover, IGrid grid)
        {
            Fake = "Backward.MoveFromSudDirection";
        }
    }
}
