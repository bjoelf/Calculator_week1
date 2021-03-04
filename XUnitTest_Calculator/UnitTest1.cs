using Xunit;
using Calculator_week3;
using System.Diagnostics;

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
            double test = Calculator.Subtraction(3, 2);
            Assert.Equal(1, test);
        }
        [Fact]
        public void Multiplying_2values()
        {
            double test = Calculator.Multiplying(3, 2);
            Assert.Equal(6, test);
        }
        [Fact]
        public void Division_2values()
        {
            double test = Calculator.Division(50, 2);
            Assert.Equal(25, test);
        }
        [Fact]
        public void Division_Zero_Denominator()
        {
            double test = Calculator.Division(3, 0);
            Assert.Equal(0, test);
        }
        [Fact]
        public void Addition_arrayvalues()
        {
            double[] toMethod = new double[4] { 3, 5, 7, 8};
            double test = Calculator.Addition(toMethod);
            Debug.Print("Addition_arrayvalues: " + test);
            Assert.Equal(23, test);
        }

        [Fact]
        public void TestAdditionWithZeroArrayValues()
        {
            double[] toMethod = new double[4] { 0, 0, 0, 0 };
            double test = Calculator.Addition(toMethod);
            Assert.Equal(0, test);
        }

        [Fact]
        public void TestAdditionWithMixedArrayValues()
        {
            double[] toMethod = new double[5] { 100, -200, 0, 3, -5 };
            double test = Calculator.Addition(toMethod);
            Debug.Print("TestAdditionWithMixedArrayValues: " + test);
            Assert.Equal(-102, test);
        }

        [Fact]
        public void Subtraction_arrayvalues()
        {
            double[] toMethod = new double[4] { 3, 5, 7, 8 };
            double test = Calculator.Subtraction(toMethod);
            Debug.Print("Subtraction_arrayvalues: " + test);
            Assert.Equal(-23, test);
        }

        [Fact]
        public void TestSubtractionWithZeroArrayValues()
        {
            double[] toMethod = new double[4] { 0, 0, 0, 0 };
            double test = Calculator.Subtraction(toMethod);
            Debug.Print("TestSubtractionWithZeroArrayValues: " + test);
            Assert.Equal(0, test);
        }

    }
}
