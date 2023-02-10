using Moq;
namespace StringCalculator;

public class StringCalculatorInteractionTests
{

    [Theory]
    [InlineData("1,2", "3")]
    [InlineData("1,2,3,4,5,6,7,8,9", "45")]
    public void AnswersAreLoggedToLogger(string numbers, string expected)
    {
        // Given
        var mockedLogger = new Mock<ILogger>();
        var calculator = new StringCalculator(mockedLogger.Object); // NEED SOMETHING HERE

        // When
        calculator.Add(numbers);

        // Then
        // I need to verify (assert) that the logger was called with the expected value!
        mockedLogger.Verify(logger => logger.Write(expected), Times.Once);
    }
}
