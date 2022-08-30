using MyClassLib;
using System;

namespace TestProject_MyClassLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Emp e1 = new Emp(5050, "Mary", new DateOnly(2005, 8, 31));
            
            DateOnly expected = new DateOnly(2005, 8, 31);

            //Act
            DateOnly actual = e1.doj;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }


}