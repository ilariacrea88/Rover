using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Rover.UnitTests
{
    [TestClass]
    public class ForewardTest
    {
        /// <summary>
        /// it is not responsability of this class check if a movement is possible or
        /// call the right method based on the mars orientation
        /// in other word this class is blind about mars orientation
        /// </summary>
        [TestMethod]
        public void MoveFromOvestDirection_MoveRoverInXMinusOne()
        {
            Foreward F = new Foreward();
            //rover orientation is ovest direction, is not responsibility of this class check direction
            RoverMars R = new RoverMars('O');
            //rover actual position is 1,1
            R.Position.X = 1;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromOvestDirection(R, G);
            Point expectedNewRoverPosition = new Point(0, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromOvestDirection_NewRoverPoint_OutOfGrid_Expected_NewXEqualsZero()
        {
            Foreward F = new Foreward();
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            RoverMars R = new RoverMars('O');
            //rover orientation is ovest direction
            //rover actual position is an impossible point since in the reality this case never occurs
            R.Position.X = 7;
            R.Position.Y = 1;
            F.MoveFromOvestDirection(R, G);
            Point expectedNewRoverPosition = new Point(0, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromOvestDirection_NewRoverPoint_OutOfGridValueLessThenZero_Expected_NewXEqualsMaxXOfGrid()
        {
            {
                Foreward F = new Foreward();
                Grid G = new Grid(5, 5, new FakeObstacleGenerator());
                RoverMars R = new RoverMars('O');
                R.Position.X = 0;
                R.Position.Y = 2;
                F.MoveFromOvestDirection(R, G);
                Point expectedNewRoverPosition = new Point(5, 2);
                Assert.AreEqual(expectedNewRoverPosition, R.Position);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MoveFromOvestDirection_ObstaclePoint_ThrowException()
        {
            Foreward F = new Foreward();
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            RoverMars R = new RoverMars('O');
            R.Position.X = 3;
            R.Position.Y = 2;
            F.MoveFromOvestDirection(R, G);
            
        }
        [TestMethod]
        public void MoveFromEstDirection_MoveRoverInXPlusOne()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('E');
            R.Position.X = 1;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromEstDirection(R, G);
            Point expectedNewRoverPosition = new Point(2, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromEstDirection_NewRoverPoint_OutOfGrid_Expected_NewXEqualsZero()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('E');
            R.Position.X = 5;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromEstDirection(R, G);
            Point expectedNewRoverPosition = new Point(0, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        public void MoveFromEstDirection_NewRoverPoint_OutOfGridValueLessThenZero_Expected_NewXEqualsMaxXOfGrid()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('E');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = -2;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromEstDirection(R, G);
            Point expectedNewRoverPosition = new Point(5, 1);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MoveFromEstDirection_ObstaclePoint_ThrowException()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('E');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 1;
            R.Position.Y = 2;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromEstDirection(R, G);
      
        }

        //MOVE FROM NORD DIRECTION
        [TestMethod]
        public void MoveFromNordDirection_MoveRoverInYPlusOne()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('N');
            R.Position.X = 1;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromNordDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 2);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromNordDirection_NewRoverPoint_OutOfGrid_Expected_NewYEqualsZero()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('N');
            R.Position.X = 1;
            R.Position.Y = 5;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromNordDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 0);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        public void MoveFromNordDirection_NewRoverPoint_OutOfGridValueLessThenZero_Expected_NewYEqualsMaxYOfGrid()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('N');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 1;
            R.Position.Y = -2;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromNordDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 5);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MoveFromNordDirection_ObstaclePoint_ThrowException()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('N');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 2;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromNordDirection(R, G);

        }

        //MOVE FROM SUD DIRECTION

        [TestMethod]
        public void MoveFromSudDirection_MoveRoverInYMinusOne()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('S');
            R.Position.X = 1;
            R.Position.Y = 1;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromSudDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 0);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }
        [TestMethod]
        public void MoveFromSudDirection_NewRoverPoint_OutOfGrid_Expected_NewYEqualsZero()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('S');
            //cannot happen
            R.Position.X = 1;
            R.Position.Y = 7;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromSudDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 0);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        public void MoveFromSudDirection_NewRoverPoint_OutOfGridValueLessThenZero_Expected_NewYEqualsMaxYOfGrid()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('S');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 1;
            R.Position.Y = 0;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromSudDirection(R, G);
            Point expectedNewRoverPosition = new Point(1, 5);
            Assert.AreEqual(expectedNewRoverPosition, R.Position);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MoveFromSudDirection_ObstaclePoint_ThrowException()
        {
            Foreward F = new Foreward();
            RoverMars R = new RoverMars('S');
            // this case should never happen but this class does not know
            // i give to the rover an impossible point
            R.Position.X = 2;
            R.Position.Y = 3;
            Grid G = new Grid(5, 5, new FakeObstacleGenerator());
            F.MoveFromSudDirection(R, G);

        }

    }
}
