namespace MyPackageName.Tests.CalculatorTests;

public class When_Subtracting_Two_Integers : CalculatorSpecificationBase
{
    private int _num1, _num2, _difference;

    protected override void Given()
    {
        base.Given();

        _num1 = 75;
        _num2 = 34;
    }

    protected override void When()
    {
        base.When();

        _difference = Calculator.Subtract(_num1, _num2);
    }

    [Then]
    public void It_Should_Return_The_Difference_Of_The_Two_Integers()
    {
        _difference.Should().Be(41);
    }
}
