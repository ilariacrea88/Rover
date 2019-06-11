using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rover.UnitTests
{
    [TestClass]
    public class RightTest
    {
        [TestMethod]
       public void MoveFromNordDirection_TurnRight_newExpectedDirection_E()
        {
            var r = new RoverMars('N');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var R = new Right();
            R.MoveFromNordDirection(r, g);
            char expected = 'E';
            Assert.AreEqual(expected,r.Direction);
        
    }
        [TestMethod]
        public void MoveFromSudDirection_TurnRight_newExpectedDirection_O()
        {
            var r = new RoverMars('S');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var R = new Right();
            R.MoveFromSudDirection(r, g);
            char expected = 'O';
            Assert.AreEqual(expected, r.Direction);
        }


        [TestMethod]
        public void MoveFromOvestDirection_TurnRight_newExpectedDirection_N()
        {
            var r = new RoverMars('O');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var R = new Right();
            R.MoveFromOvestDirection(r, g);
            char expected = 'N';
            Assert.AreEqual(expected, r.Direction);
        }

        [TestMethod]
        public void MoveFromEstDirection_TurnRight_newExpectedDirection_S()
        {
            var r = new RoverMars('E');
            var g = new Grid(4, 4, new FakeObstacleGenerator());
            var R = new Right();
            R.MoveFromEstDirection(r, g);
            char expected = 'S';
            Assert.AreEqual(expected, r.Direction);
        }
    }
}
