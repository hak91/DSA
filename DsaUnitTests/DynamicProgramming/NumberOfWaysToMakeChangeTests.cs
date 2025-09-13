using DynamicProgramming;

namespace DsaUnitTests.DynamicProgramming;
public class NumberOfWaysToMakeChangeTests
{
    [Fact]
    public void NumberOfWaysMakeChange_For_Zero_Is_1()
    {
        // Arrange
        int[] denoms = [1, 5];
        var n = 0;

        // Act
        var result = NumberOfWaysToMakeChangeCalc.NumberOfWaysToMakeChange(n, denoms);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void NumberOfWaysToMakeChange_Should_Return_Expected()
    {
        // Arrange
        int[] denoms = { 1, 5 };
        var n = 6;

        // Act
        var result = NumberOfWaysToMakeChangeCalc.NumberOfWaysToMakeChange(n, denoms);

        // Assert
        Assert.Equal(2, result);
    }
}
