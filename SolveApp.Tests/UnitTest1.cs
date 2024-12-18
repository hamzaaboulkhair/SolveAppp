using SolveApp;
using Xunit;

namespace SolveApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSolveQuadraticWithTwoRealRoots()
        {
            
            double a = 1;
            double b = -3;
            double c = 2;

           
            var result = Program.SolveQuadratic(a, b, c);

            
            Assert.NotNull(result);
            Assert.Equal(2, result.X1);
            Assert.Equal(1, result.X2);
        }

        [Fact]
        public void TestSolveQuadraticWithNoRealRoots()
        {
           
            double a = 1;
            double b = 1;
            double c = 1;

           
            var result = Program.SolveQuadratic(a, b, c);

           
            Assert.NotNull(result);
            Assert.Null(result.X1);
            Assert.Null(result.X2);
        }

        [Fact]
        public void TestSolveQuadraticWithOneRealRoot()
        {
            // Arrange
            double a = 1;
            double b = -2;
            double c = 1;

            // Act
            var result = Program.SolveQuadratic(a, b, c);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.X1);
            Assert.Equal(1, result.X2);
        }
    }
}
