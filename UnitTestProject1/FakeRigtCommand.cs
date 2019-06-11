namespace Rover.UnitTests
{
    public class FakeRigtCommand : Command
    {
        public string Fake { get; set; } 

        public override void MoveFromEstDirection(IRover rover, IGrid grid)
        {
            Fake = "Right.MoveFromEstDirection";
        }

        public override void MoveFromNordDirection(IRover rover, IGrid grid)
        {
            Fake = "Rigth.MoveFromNordDirection";
        }

        public override void MoveFromOvestDirection(IRover rover, IGrid grid)
        {
            Fake = "Right.MoveFromOvestDirection";
        }

        public override void MoveFromSudDirection(IRover rover, IGrid grid)
        {
            Fake = "Right.MoveFromSudDirection";
        }

    }
}
