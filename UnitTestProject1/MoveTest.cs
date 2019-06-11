using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Rover.UnitTests
{

    [TestClass]
    public class MoveTest
    {
        //CASE NORD DIRECTION
        [TestMethod]
        public void MoveRover_RoverDirectionNLeftImputCommand_MoveFromNordDirectionOfLeftCommandIsCalled()
        {
            var rover = new RoverMars('N');
            var g = new Grid(4,4,new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeLeftCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeLeftCommand;
            Assert.IsTrue("Left.MoveFromNordDirection".Equals(TestCommand.Fake));
     
        }
        [TestMethod]
        public void MoveRover_RoverDirectionNRightInputCommand_MoveFromNordDirectionOfRightCommandIsCalled()
        {
            var rover = new RoverMars('N');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeRigtCommand()};
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeRigtCommand;
            Assert.IsTrue("Rigth.MoveFromNordDirection".Equals(TestCommand.Fake));

        }

        [TestMethod]
        public void MoveRover_RoverDirectionNForewardtInputCommand_MoveFromNordDirectionOfForewardCommandIsCalled()
        {
            var rover = new RoverMars('N');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeForewardCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeForewardCommand;
            Assert.IsTrue("Foreward.MoveFromNordDirection".Equals(TestCommand.Fake));

        }

        [TestMethod]
        public void MoveRover_RoverDirectionNBackwardtInputCommand_MoveFromNordDirectionOfBackwardCommandIsCalled()
        {
            var rover = new RoverMars('N');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeBackwardCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeBackwardCommand;
            Assert.IsTrue("Backward.MoveFromNordDirection".Equals(TestCommand.Fake));

        }
        //CASE SUD DIRECTION
        [TestMethod]
        public void MoveRover_RoverDirectionSLeftImputCommand_MoveFromSudDirectionOfLeftCommandIsCalled()
        {
            var rover = new RoverMars('S');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeLeftCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeLeftCommand;
            Assert.IsTrue("Left.MoveFromSudDirection".Equals(TestCommand.Fake));

        }
        [TestMethod]
        public void MoveRover_RoverDirectionSRightInputCommand_MoveFromSudDirectionOfRightCommandIsCalled()
        {
            var rover = new RoverMars('S');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeRigtCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeRigtCommand;
            Assert.IsTrue("Right.MoveFromSudDirection".Equals(TestCommand.Fake));

        }

        [TestMethod]
        public void MoveRover_RoverDirectionSForewardtInputCommand_MoveFromSudDirectionOfForewardCommandIsCalled()
        {
            var rover = new RoverMars('S');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeForewardCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeForewardCommand;
            Assert.IsTrue("Foreward.MoveFromSudDirection".Equals(TestCommand.Fake));

        }

        [TestMethod]
        public void MoveRover_RoverDirectionSBackwardtInputCommand_MoveFromSudDirectionOfBackwardCommandIsCalled()
        {
            var rover = new RoverMars('S');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeBackwardCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeBackwardCommand;
            Assert.IsTrue("Backward.MoveFromSudDirection".Equals(TestCommand.Fake));

        }

        //OVEST SCENARIO

        [TestMethod]
        public void MoveRover_RoverDirectionOLeftImputCommand_MoveFromoVESTDirectionOfLeftCommandIsCalled()
        {
            var rover = new RoverMars('O');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeLeftCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeLeftCommand;
            Assert.IsTrue("Left.MoveFromOvestDirection".Equals(TestCommand.Fake));

        }
        [TestMethod]
        public void MoveRover_RoverDirectionORightInputCommand_MoveFromOvestDirectionOfRightCommandIsCalled()
        {
            var rover = new RoverMars('O');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeRigtCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeRigtCommand;
            Assert.IsTrue("Right.MoveFromOvestDirection".Equals(TestCommand.Fake));

        }

        [TestMethod]
        public void MoveRover_RoverDirectionOForewardtInputCommand_MoveFromOvestDirectionOfForewardCommandIsCalled()
        {
            var rover = new RoverMars('O');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeForewardCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeForewardCommand;
            Assert.IsTrue("Foreward.MoveFromOvestDirection".Equals(TestCommand.Fake));

        }

        [TestMethod]
        public void MoveRover_RoverDirectionOBackwardtInputCommand_MoveFromOvestDirectionOfBackwardCommandIsCalled()
        {
            var rover = new RoverMars('O');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeBackwardCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeBackwardCommand;
            Assert.IsTrue("Backward.MoveFromOvestDirection".Equals(TestCommand.Fake));

        }

        //EST SCENARIO

        [TestMethod]
        public void MoveRover_RoverDirectionELeftImputCommand_MoveFromoVESTDirectionOfLeftCommandIsCalled()
        {
            var rover = new RoverMars('E');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeLeftCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeLeftCommand;
            Assert.IsTrue("Left.MoveFromEstDirection".Equals(TestCommand.Fake));

        }
        [TestMethod]
        public void MoveRover_RoverDirectionERightInputCommand_MoveFromEstDirectionOfRightCommandIsCalled()
        {
            var rover = new RoverMars('E');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeRigtCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeRigtCommand;
            Assert.IsTrue("Right.MoveFromEstDirection".Equals(TestCommand.Fake));

        }

        [TestMethod]
        public void MoveRover_RoverDirectionEForewardtInputCommand_MoveFromEstDirectionOfForewardCommandIsCalled()
        {
            var rover = new RoverMars('E');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeForewardCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeForewardCommand;
            Assert.IsTrue("Foreward.MoveFromEstDirection".Equals(TestCommand.Fake));

        }

        [TestMethod]
        public void MoveRover_RoverDirectionEBackwardtInputCommand_MoveFromEstDirectionOfBackwardCommandIsCalled()
        {
            var rover = new RoverMars('E');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var command = new List<ICommand> { new FakeBackwardCommand() };
            Move.MoveRover(rover, g, command);
            var TestCommand = command[0] as FakeBackwardCommand;
            Assert.IsTrue("Backward.MoveFromEstDirection".Equals(TestCommand.Fake));

        }

    }
}
