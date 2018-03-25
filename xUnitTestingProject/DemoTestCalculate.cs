using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DemoLibrary;

namespace xUnitTestingProject
{
    public class DemoTestCalculate
    {
        [Fact]
        public void Add_DemoCalculate()
        {
            //Arrange
            int expected = 7;
            Calculate calc = new Calculate();
            //Act
            int result = calc.Add(3, 4);
            //Assert
            Assert.Equal(expected, result);
            
        }

        [Theory]
        [InlineData(4, 5, 9)]
        [InlineData(4, 5, 9)]
        [InlineData(4, 1, 5)]
        public void Add_DemoCalculateWithParameter(int x, int y, int expected)
        {
            //Arrange
            Calculate calc = new Calculate();
            //Act
            int result = calc.Add(x, y);
            //Assert
            Assert.Equal(expected, result);
           
        }

        [Fact]
        public void Divide_DemoCalculate()
        {
            int expected = 7;
            //Arrange
            Calculate calc = new Calculate();
            //Act
            int result = calc.Divide(49, 7);
            //Assert
            Assert.Equal(expected, result);

        }

        [Fact]
        public void Divide_DemoCalculateException()
        {
            //Arrange
            Calculate calc = new Calculate();
            //Assert
            Assert.Throws<ArgumentException>(() => calc.Divide(49, 0));

        }
        //Done Testing
    }
}
