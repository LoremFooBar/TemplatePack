namespace lfb_package.Tests.CalculatorTests;

public class When_Dividing_Two_Integers : CalculatorSpecificationBase
{
    private int _dividend, _divisor;
    private decimal _quotient;

    protected override void Given()
    {
        base.Given();

        _dividend = 81;
        _divisor = 2;
    }

    protected override void When()
    {
        base.When();

        _quotient = Calculator.Divide(_dividend, _divisor);
    }

    [Then]
    public void Is_Should_Return_The_Quotient_Of_The_Two_Integers()
    {
        _quotient.Should().Be(40.5m);
    }
}
