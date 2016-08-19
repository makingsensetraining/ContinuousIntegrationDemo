using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetSDK;

namespace Net_SDK_Unit_Tests
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void Demo_result_should_starts_with_hi()
        {
            //Arrange
            var sut = new Service();

            //Act
            var result = sut.Demo("name");

            //Assert
            Assert.IsTrue(result.StartsWith("Hi"));
        }

        [TestMethod]
        public void Demo_result_should_ends_with_the_name()
        {
            //Arrange
            var sut = new Service();
            var name = "name";

            //Act
            var result = sut.Demo(name);

            //Assert
            Assert.IsTrue(result.EndsWith(name));
        }
    }
}
