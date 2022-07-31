namespace MyPackageName.Tests.CalculatorTests;

public class When_Multiplying_Two_Integers : CalculatorSpecificationBase
{
    private int _num1, _num2, _productOf;

    protected override void Given()
    {
        base.Given();

        _num1 = 7;
        _num2 = 107;
    }

    protected override void When()
    {
        _productOf = Calculator.Multiply(_num1, _num2);
    }

    [Then]
    public void Is_Should_Return_The_Product_Of_The_Two_Integers()
    {
        _productOf.Should().Be(749);
    }
}
