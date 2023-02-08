
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("", 0)]
    [InlineData("1", 1)]
    [InlineData("10", 10)]
    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1, 2, 3", 6)]
    [InlineData("10, 20, 30", 60)]
    [InlineData("1\n2,3", 6)]
    public void MultipleDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
}
