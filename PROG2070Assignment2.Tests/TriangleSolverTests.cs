using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using NUnit.Framework;

namespace PROG2070Assignment2.Tests
{
    [TestFixture]
    class TriangleSolverTests
    {
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
        }
    }
}
