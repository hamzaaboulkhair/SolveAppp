using NUnit.Framework;
using SolveApp;

namespace SolveApp.Tests
{
    [TestFixture]
    public class UnitTest1
    {
       [Test]
public void TestSolveQuadraticWithOneRealRoot()
{
    // Arrange
    double a = 1;
    double b = -2;
    double c = 1;

    // Act
    var result = Program.SolveQuadratic(a, b, c);

    // Assert
    Assert.That(result, Is.Not.Null, "The result should not be null.");
    Assert.That(result.X1, Is.EqualTo(1), "X1 should be 1.");
    Assert.That(result.X2, Is.Null, "X2 should be null for a single root.");
}

    }
}
