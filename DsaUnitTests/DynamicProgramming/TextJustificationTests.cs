using DynamicProgramming;
using FluentAssertions;

namespace DsaUnitTests.DynamicProgramming;
public class TextJustificationTests
{
    [Fact]
    public void Run_ShouldPrintResult_ForGivenWordsAndLineWidth()
    {
        // Arrange
        var words = new[] { "This", "is", "a", "test" };
        int lineWidth = 10;
        var justification = new TextJustification();

        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        justification.Run(words, lineWidth);

        // Assert
        var output = sw.ToString();
        output.Should().Contain("Result:");
    }
}
