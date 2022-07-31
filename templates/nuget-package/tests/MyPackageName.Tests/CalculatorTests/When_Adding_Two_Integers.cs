namespace MyPackageName.Tests.CalculatorTests;

public class When_Adding_Two_Integers : CalculatorSpecificationBase
{
    private int _num1, _num2, _sum;

    protected override void Given()
    {
        base.Given();

        _num1 = 47;
        _num2 = 11;
    }

    protected override void When()
    {
        base.When();

        _sum = Calculator.Add(_num1, _num2);
    }

    [Then]
    public void It_Should_Return_The_Sum_Of_The_Two_Integers()
    {
        _sum.Should().Be(58);
    }
}
