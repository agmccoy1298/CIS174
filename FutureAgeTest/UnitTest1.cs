using System;
using Xunit;
using FirstResponsiveWebAppMcCoy.Models;
using FirstResponsiveWebAppMcCoy.Controllers;

namespace FutureAgeTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassingCaseTest()
        {
            // Arrange            
            
            DateTime date = DateTime.Now;
            int birthYear = 1998;           
            int actual;
            int expected = 24;

            // Act            
            actual = AgeModel.AgeThisYear(date, birthYear);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]

        public void PassingCaseTest2()
        {
            // Arrange            

            DateTime date = DateTime.Now;
            int birthYear = 2045;
            int actual;
            int expected = 0;

            // Act                        
            actual = AgeModel.AgeThisYear(date, birthYear);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
