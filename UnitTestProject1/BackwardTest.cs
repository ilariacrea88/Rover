using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Rover.UnitTests
{
    /*the obstacle generator has a logic a bit more complicated  respect to grid and rover so it is the only one which 
     i provide a fake one for the test
    */
  
    [TestClass]
    public class BackwordTest
    {
        [TestMethod]
        public void MoveFromOvestDirection_MoveRoverInXPluOne()
        {
            Backward B = new Backward();
            //rover orientation is ovest direction, is not responsibility of this class check direction
            RoverMars R = new RoverMars('O');
            //rover actual position is 1,1
            R.Position.X = 1;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromOvestDirection(R, G);
            Point expectedNewRoverPosition = new Point(2, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromOvestDirection_NewRoverPoint_OutOfGrid_Expected_NewXEqualsZero()
        {
            var B = new Backward();
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            RoverMars R = new RoverMars('O');
            //rover orientation is ovest direction
            R.Position.X = 5;
            R.Position.Y = 1;
            B.MoveFromOvestDirection(R, G);
            Point expectedNewRoverPosition = new Point(0, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromOvestDirection_NewRoverPoint_OutOfGridValueLessThenZero_Expected_NewXEqualsMaxXOfGrid()
        {
            {
                var B = new Backward();
                Grid G = new Grid(5, 5, new FakeObstacleGenerator());
                RoverMars R = new RoverMars('O');
                R.Position.X = -2;
                R.Position.Y = 2;
                B.MoveFromOvestDirection(R, G);
                Point expectedNewRoverPosition = new Point(5, 2);
                Assert.AreEqual(expectedNewRoverPosition, R.Position);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MoveFromOvestDirection_ObstaclePoint_ThrowException()
        {
            var B = new Backward();
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            RoverMars R = new RoverMars('O');
            R.Position.X = 1;
            R.Position.Y = 2;
            B.MoveFromOvestDirection(R, G);
            
        }
        [TestMethod]
        public void MoveFromEstDirection_MoveRoverInXMinusOne()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('E');
            R.Position.X = 1;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromEstDirection(R, G);
            Point expectedNewRoverPosition = new Point(0, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromEstDirection_NewRoverPoint_OutOfGrid_Expected_NewXEqualsZero()
        {
            Backward B = new Backward();
            RoverMars R = new RoverMars('E');
            R.Position.X = 7;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromEstDirection(R, G);
            Point expectedNewRoverPosition = new Point(0, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        public void MoveFromEstDirection_NewRoverPoint_OutOfGridValueLessThenZero_Expected_NewXEqualsMaxXOfGrid()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('E');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 0;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromEstDirection(R, G);
            Point expectedNewRoverPosition = new Point(5, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MoveFromEstDirection_ObstaclePoint_ThrowException()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('E');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 3;
            R.Position.Y = 2;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromEstDirection(R, G);
      
        }

        //MOVE FROM NORD DIRECTION
        [TestMethod]
        public void MoveFromNordDirection_MoveRoverInYMinusOne()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('N');
            R.Position.X = 1;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromNordDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 0);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromNordDirection_NewRoverPoint_OutOfGrid_Expected_NewYEqualsZero()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('N');
            R.Position.X = 1;
            R.Position.Y = 7;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromNordDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 0);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        public void MoveFromNordDirection_NewRoverPoint_OutOfGridValueLessThenZero_Expected_NewYEqualsMaxYOfGrid()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('N');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 1;
            R.Position.Y = 0;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromNordDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 5);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MoveFromNordDirection_ObstaclePoint_ThrowException()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('N');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 2;
            R.Position.Y = 3;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromNordDirection(R, G);

        }

        //MOVE FROM SUD DIRECTION

        [TestMethod]
        public void MoveFromSudDirection_MoveRoverInYPlusOne()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('S');
            R.Position.X = 1;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromSudDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 2);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromSudDirection_NewRoverPoint_OutOfGrid_Expected_NewYEqualsZero()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('S');
            //cannot happen
            R.Position.X = 1;
            R.Position.Y = 5;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromSudDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 0);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        public void MoveFromSudDirection_NewRoverPoint_OutOfGridValueLessThenZero_Expected_NewYEqualsMaxYOfGrid()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('N');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 1;
            R.Position.Y = -2;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromSudDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 5);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MoveFromSudDirection_ObstaclePoint_ThrowException()
        {
            var B = new Backward();
            RoverMars R = new RoverMars('N');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 2;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            B.MoveFromSudDirection(R, G);

        }

    }
}
