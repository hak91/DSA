using ArrayProblems;

namespace DsaUnitTests.Arrays;

public class BestSeatTests
{
    [Fact]
    public void BestSeat_Should_Return_Correct_Position()
    {
        // Arrange
        var input = new int[] { 1, 0, 1, 0, 0, 0, 1 };
        var expected = 4;
        var bestSeat = new BestSeat();

        // Act
        var result = bestSeat.MyProgram.BestSeat(input);

        // Assert
        Assert.True(result == expected);
    }
}
