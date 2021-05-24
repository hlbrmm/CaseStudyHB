using MarsRover.Manager;
using MarsRover.Models;
using NUnit.Framework;

namespace MarsRover.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Map_Constructor_Should_Be_Set_X_Y_Coordinates_()
        {
            //Arrange
            int xCoordinate = 10;
            int yCoordinate = 10;

            //Act 
            Map map = new Map(xCoordinate, yCoordinate);

            //Assert
            Assert.AreEqual(xCoordinate, map.XCoordinate);
            Assert.AreEqual(yCoordinate, map.YCoordinate);
        }

        [Test]
        public void Rover_Constructor_ShouldBe_Set_XCoordinateOfRover_YCoordinateOfRover_Direction_Fields_()
        {
            //Arrange
            int xCoordinateOfRover = 5;
            int yCoordinateOfRover = 5;
            char Direction = 'C';

            //Act 
            Rover rover = new Rover(xCoordinateOfRover, yCoordinateOfRover, Direction);

            //Assert
            Assert.AreEqual(xCoordinateOfRover, rover.XCoordinate);
            Assert.AreEqual(yCoordinateOfRover, rover.YCoordinate);
            Assert.AreEqual(Direction, rover.Direction);
        }

        [Test]
        public void GetPositionOfRover_Should_Return_00N_When_ConstructorSets_00N_()
        {
            //Arrange
            Rover rover = new Rover(0, 0, 'N');
            string exceptedValue = "0 0 N";

            //Act 
            RoverManager roverManager = new RoverManager();
            string actualValue = roverManager.GetPositionOfRover(rover);

            //Assert
            Assert.AreEqual(exceptedValue, actualValue);
        }

        [Test]
        public void CanRoverMove_Should_Return_False_If_Rover_OutOf_Border_()
        {
            //Arrange
            int borderTopCorner = 10;
            int roverDestination = 11;
            RoverManager roverManager = new RoverManager();

            //Act 
            bool actualValue = roverManager.CanRoverMove(borderTopCorner, roverDestination);

            //Assert
            Assert.AreEqual(false, actualValue);
        }

        [Test]
        public void CanRoverMove_Should_Return_True_If_Rover_InThe_BorderLine_()
        {
            //Arrange
            int borderTopCorner = 11;
            int roverDestination = 10;
            RoverManager roverManager = new RoverManager();

            //Act 
            bool actualValue = roverManager.CanRoverMove(borderTopCorner, roverDestination);

            //Assert
            Assert.AreEqual(true, actualValue);
        }

        [Test]
        public void Output_ShouldBe_1_3_N_Located_1_2_N_Position_On_5x5_Plateu_()
        {
            //Arrange
            Map map = new Map(5, 5);
            RoverManager roverManager = new RoverManager();
            Rover rover = new Rover(1, 2, 'N');
            string expectedOutput = "1 3 N";

            //Act
            roverManager.MoveRover(rover, map, "LMLMLMLMM");

            //Assert
            Assert.AreEqual(expectedOutput, roverManager.GetPositionOfRover(rover));
        }

        [Test]
        public void Output_ShouldBe_5_1_E_Located_3_3_E_Position_On_5x5_Plateu_()
        {
            //Arrange
            Map map = new Map(5, 5);
            RoverManager roverManager = new RoverManager();
            Rover rover = new Rover(3, 3, 'E');
            string expectedOutput = "5 1 E";

            //Act
            roverManager.MoveRover(rover, map, "MMRMMRMRRM");

            //Assert
            Assert.AreEqual(expectedOutput, roverManager.GetPositionOfRover(rover));
        }

        [Test]
        public void Output_ShouldBe_4_1_E_Located_3_3_E_Position_On_4x4_Plateu()
        {
            //Arrange
            Map map = new Map(4, 4);
            RoverManager roverManager = new RoverManager();
            Rover rover = new Rover(3, 3, 'E');
            string expectedOutput = "4 1 E";

            //Act
            roverManager.MoveRover(rover, map, "MMRMMRMRRM");

            //Assert
            Assert.AreEqual(expectedOutput, roverManager.GetPositionOfRover(rover));
        }

        [Test]
        public void Output_ShouldBe_3_3_N_Located_0_0_N_Position_On_3x3_Plateu()
        {
            //Arrange
            Map map = new Map(3, 3);
            RoverManager roverManager = new RoverManager();
            Rover rover = new Rover(0, 0, 'N');
            string expectedOutput = "3 3 N";

            //Act
            roverManager.MoveRover(rover, map, "MRMLMRMLMRML");

            //Assert
            Assert.AreEqual(expectedOutput, roverManager.GetPositionOfRover(rover));
        }
    }
}