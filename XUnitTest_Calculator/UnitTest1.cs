using Xunit;
using Calculator_week3;

namespace XUnitTest_Calculator
{
    public class UnitTest1
    {
        [Fact]
        public void SimpleAddition_2values()
        {
            double test = Calculator.Addition(3, 2);
            Assert.Equal(5, test);
        }

        [Fact]
        public void SimpleSubtraction_2values()
        {
            double test = Calculator.Addition(3, 2);
            Assert.Equal(5, test);
        }
        [Fact]
        public void Multiplying_2values()
        {
            double test = Calculator.Addition(3, 2);
            Assert.Equal(5, test);
        }
        [Fact]
        public void Division_2values()
        {
            double test = Calculator.Addition(3, 2);
            Assert.Equal(5, test);
        }
        [Fact]
        public void Division_Zero_Denominator()
        {
            double test = Calculator.Addition(3, 2);
            Assert.Equal(5, test);
        }
        [Fact]
        public void Addition_arrayvalues()
        {
            double[] toMethod = new double[4] { 3, 5, 7, 8};
            double test = Calculator.Addition(toMethod);
            Assert.Equal(23, test);
        }
        [Fact]
        public void Subtraction_arrayvalues()
        {
            double[] toMethod = new double[4] { 3, 5, 7, 8 };
            double test = Calculator.Subtraction(toMethod);
            Assert.Equal(-23, test);
        }
    }
}
