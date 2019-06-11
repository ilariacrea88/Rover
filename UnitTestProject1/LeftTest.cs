using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.UnitTests
{

    [TestClass]
    public class LeftTest
    {
        [TestMethod]
        public void MoveFromOvestDirection_turnLeft_expectedNewDirection_S()
        {
            var rover = new RoverMars('O');
            var g = new Grid(2, 3, new FakeObstacleGenerator());
            Left L = new Left();
            L.MoveFromOvestDirection(rover,g);
            char expected = 'S';
            Assert.AreEqual(expected, rover.Direction);
        }
        [TestMethod]
        public void MoveFromEstDirection_turnLeft_expectedNewDirection_N()
        {
            var rover = new RoverMars('E');
            var g = new Grid(2, 3, new FakeObstacleGenerator());
            var L = new Left();
            char expected = 'N';
            L.MoveFromEstDirection(rover, g);
            Assert.AreEqual(expected,rover.Direction);

        }

        [TestMethod]
        public void MoveFromNordDirection_turnLeft_expectedNewDirection_O()
        {
            var rover = new RoverMars('N');
            var g = new Grid(2, 3, new FakeObstacleGenerator());
            var L = new Left();
            char expected = 'O';
            L.MoveFromNordDirection(rover, g);
            Assert.AreEqual(expected, rover.Direction);

        }

        [TestMethod]
        public void MoveFromSudDirection_turnLeft_expectedNewDirection_E()
        {
            var rover = new RoverMars('S');
            var g = new Grid(2, 3, new FakeObstacleGenerator());
            var L = new Left();
            char expected = 'E';
            L.MoveFromSudDirection(rover, g);
            Assert.AreEqual(expected, rover.Direction);

        }
    }
}
