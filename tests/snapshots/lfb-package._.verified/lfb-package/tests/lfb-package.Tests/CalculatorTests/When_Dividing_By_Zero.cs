namespace lfb_package.Tests.CalculatorTests;

public class When_Dividing_By_Zero : CalculatorSpecificationBase
{
    private Func<decimal> _divisionAction;

    protected override void When()
    {
        _divisionAction = () => Calculator.Divide(59, 0);
    }

    [Then]
    public void It_Should_Throw_DivideByZeroException()
    {
        _divisionAction.Should().Throw<DivideByZeroException>();
    }
}
