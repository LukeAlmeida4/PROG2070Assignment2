using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
    }
}
