using DynamicProgramming;
using FluentAssertions;

namespace DsaUnitTests.DynamicProgramming;
public class MaxSubsetSumNoAdjacentTests
{
    [Fact]
    public void MaxSubsetSumNoAdjacent_Should_Return_Expected_Value()
    {
        // Arrange
        int[] input = [75, 105, 120, 75, 90, 135];

        //Act
        var result = MaxSubsetSumNoAdjacentCalc.MaxSubsetSumNoAdjacent(input);

        //Assert
        result.Should().Be(330);
    }

    [Fact]
    public void MaxSubsetSumNoAdjacent_Should_Return_Zero_For_Empty()
    {
        // Arrange
        int[] input = [];

        //Act
        var result = MaxSubsetSumNoAdjacentCalc.MaxSubsetSumNoAdjacent(input);

        //Assert
        result.Should().Be(0);
    }
}
