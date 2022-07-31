using LoremFooBar.SimpleGwt.NUnit;

namespace MyPackageName.Tests.CalculatorTests;

public class CalculatorSpecificationBase : SpecificationBase
{
    protected Calculator Calculator { get; } = new();
}
