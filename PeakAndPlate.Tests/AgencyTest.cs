using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeakAndPlate.Model;
using PeakAndPlate.Controller;

namespace PeakAndPlate.Tests
{
    [TestClass]
    public class AgencyTest
    {
        [TestMethod]
        public void IsValid_PlateWithInvalidFormat()
        {
            //Arrange
            var Agency = new Agency();

            //Act
            var Result = Agency.PlateValidate(new Car { Plate = "PA-12345" });

            //Assert
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void IsValid_PlateWithValidFormat()
        {
            //Arrange
            var Agency = new Agency();

            //Act
            var Result = Agency.PlateValidate(new Car { Plate = "PCA-1234" });

            //Assert
            Assert.IsTrue(Result);
        }

        [TestMethod]
        public void IsValid_PeakAndPlate_PlateWithInvalidFormat()
        {
            //Arrange
            var Agency = new Agency();
            DateTime DateTimeSelected = new DateTime(2018, 02, 19);
            TimeSpan HourSelected = new TimeSpan(9, 23, 0);
            var ExpectedResult = "THE PLATE IS INVALID";

            //Act
            var Result = Agency.PeakAndPlate(new Car { Plate = "PA-12345" }, DateTimeSelected, HourSelected);

            //Assert
            Assert.AreSame(ExpectedResult, Result);
        }

        [TestMethod]
        public void IsValid_PeakAndPlate_PlateWithValidFormat_OnTheRoad()
        {
            //Arrange
            var Agency = new Agency();
            DateTime DateTimeSelected = new DateTime(2018, 02, 19); //Monday
            TimeSpan HourSelected = new TimeSpan(9, 23, 0);
            var ExpectedResult = "THE CAR CAN BE ON THE ROAD";

            //Act
            var Result = Agency.PeakAndPlate(new Car { Plate = "PCA-1234" }, DateTimeSelected, HourSelected);

            //Assert
            Assert.AreSame(ExpectedResult, Result);
        }

        [TestMethod]
        public void IsValid_PeakAndPlate_PlateWithValidFormat_NotOnTheRoad()
        {
            //Arrange
            var Agency = new Agency();
            DateTime DateTimeSelected = new DateTime(2018, 02, 20); //Tuesday
            TimeSpan HourSelected = new TimeSpan(9, 23, 0);
            var ExpectedResult = "THE CAR CAN NOT BE ON THE ROAD";

            //Act
            var Result = Agency.PeakAndPlate(new Car { Plate = "PCA-1234" }, DateTimeSelected, HourSelected);

            //Assert
            Assert.AreSame(ExpectedResult, Result);
        }
    }
}
