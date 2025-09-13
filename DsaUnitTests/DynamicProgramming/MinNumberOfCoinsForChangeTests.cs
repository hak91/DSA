using DynamicProgramming;

namespace DsaUnitTests.DynamicProgramming;
public class MinNumberOfCoinsForChangeTests
{
    [Fact]
    public void MinNumberOfCoinsForChange_Should_Return_Expected()
    {
        // Arrange
        var n = 6;
        var denoms = new[] { 1, 2, 4 };

        // Act
        var result = MinNumberOfCoinsForChangeCalc.MinNumberOfCoinsForChange(n, denoms);

        // Assert
        Assert.Equal(2, result);
    }
}
