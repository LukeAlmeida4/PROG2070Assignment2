using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 21cac3701b1c68bb616a5b16c0b9dd8d7d87b2bd
using NUnit.Framework;

namespace PROG2070Assignment2.Tests
{
    [TestFixture]
    class TriangleSolverTests
    {
<<<<<<< HEAD
        //Testing the analyze method to see if it will correctly check whether three sides form a proper triangle.
        //Three integers are passed through to the method, and two of the sides added must be greater than the third.
        //This test will check the first two integers added compared to the third length
        [Test]
        public void AnalyzeMethodTest_LengthsOneTwoTriangleNotFormed_ReturnsString()
        {
            string actual; //Arrange
            string expected;

            expected = "Sorry this is not a proper triangle - returning to main menu";
            actual = TriangleSolver.Analyze(2, 3, 8); //Act

            Assert.AreEqual(expected, actual); //Assert
        }

        [Test]
        //Testing the analyze method to see if it will correctly check whether three sides form a proper triangle.
        //Three integers are passed through to the method, and two of the sides added must be greater than the third.
        //This test will check the first and third integers added compared to the second length
        public void AnalyzeMethodTest_LengthsOneThreeTriangleNotFormed_ReturnsString()
        {
            string actual; //Arrange
            string expected;

            expected = "Sorry this is not a proper triangle - returning to main menu";
            actual = TriangleSolver.Analyze(2, 8, 3); //Act

            Assert.AreEqual(expected, actual); //Assert
        }

        //Testing the analyze method to see if it will correctly check whether three sides form a proper triangle.
        //Three integers are passed through to the method, and two of the sides added must be greater than the third.
        //This test will check the second and third integers added compared to the first length
        [Test]
        public void AnalyzeMethodTest_LengthsTwoThreeTriangleNotFormed_ReturnsString()
        {
            string actual; //Arrange
            string expected;

            expected = "Sorry this is not a proper triangle - returning to main menu";
            actual = TriangleSolver.Analyze(8, 3, 2); //Act

            Assert.AreEqual(expected, actual); //Assert
        }

        //Testing the analyze method to see if it will return the strong confirming an equilateral triangle. This is one of the possible
        //routes of execution for the method based on the integers passed through. All sides must be the same in length for it to return the expected string
        [Test]
        public void AnalyzeMethodTest_EquilateralCheck_ReturnsString()
        {
            string actual; //Arrange
            string expected;

            expected = "This correctly forms a triangle, thanks! After checking the numbers I have determined this is an Equilateral Triangle ";
            actual = TriangleSolver.Analyze(2,2,2); //Act

            Assert.AreEqual(expected, actual); //Assert
        }

        //Testing the analyze method to see if it will return the string confirming a scalene triangle. This is one of the possible
        //routes of execution for the method based on the integers passed through. All sides must be different in length for the expected string to return
        [Test]
        public void AnalyzeMethodTest_ScaleneCheck_ReturnsString()
        {
            string actual; //Arrange
            string expected;

            expected = "This correctly forms a triangle, thanks! After checking the numbers I have determined this is a Scalene Triangle ";
            actual = TriangleSolver.Analyze(4, 9, 11); //Act

            Assert.AreEqual(expected, actual); //Assert
        }

        //Testing the analyze method to see if it will return the string confirming a isosceles triangle. This is one of the possible
        //routes of execution for the method based on the integers passed through. Two sides must be the same in length for the expected string to return
        [Test]
        public void AnalyzeMethodTest_IsoscelesCheck_ReturnsString()
        {
            string actual; //Arrange
            string expected;

            expected = "This correctly forms a triangle, thanks! After checking the numbers I have determined this is an Isosceles Triangle ";
            actual = TriangleSolver.Analyze(6, 8, 8); //Act

            Assert.AreEqual(expected, actual); //Assert
        }
        //Testing the analyze method when input is 0
        //0 can not be used to form a valid triangle, and our program is meant to stop 0 from passing through 
        // this test ensures the argument is thrown
        [Test]
        public void AnalyzeMethodTest_WhenInputIs0_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => TriangleSolver.Analyze(0, 0, 0));
        }
        //Testing the analyze method when input is negative
        //negative values cannot be used to form a valid triangle, and our program is meant to stop 0 from passing through 
        //this test ensures the argument is thrown
        [Test]
        public void AnalyzeMethodTest_WhenInputIsNegative_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TriangleSolver.Analyze(-2, -2, -2));
=======
        //naming convention - what is under test, condition, expected bevahiour
        //arrange, act, assert
        [Test]
        public void GetLengthTest_WhenLengthIs1_Returns1()
        {
            int result; //Arrange

            result = TriangleSolver.Analyze(1,2,3); //Act

            Assert.AreEqual(1, result); //Assert
=======

namespace PROG2070Assignment2.Tests
{
    class TriangleSolverTests
    {
        static void Main(string[] args)
        {
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
>>>>>>> 21cac3701b1c68bb616a5b16c0b9dd8d7d87b2bd
        }
    }
}
