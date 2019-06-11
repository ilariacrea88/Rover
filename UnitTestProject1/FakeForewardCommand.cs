namespace Rover.UnitTests
{
    public class FakeForewardCommand : Command
    {
        public string Fake { get; set; }

        public override void MoveFromEstDirection(IRover rover, IGrid grid)
        {
            Fake = "Foreward.MoveFromEstDirection";
        }

        public override void MoveFromNordDirection(IRover rover, IGrid grid)
        {
            Fake = "Foreward.MoveFromNordDirection";
        }

        public override void MoveFromOvestDirection(IRover rover, IGrid grid)
        {
            Fake = "Foreward.MoveFromOvestDirection";
        }

        public override void MoveFromSudDirection(IRover rover, IGrid grid)
        {
            Fake = "Foreward.MoveFromSudDirection";
        }
    }
}
