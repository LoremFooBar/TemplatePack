using LoremFooBar.SimpleGwt.NUnit;

namespace lfb_package.Tests.CalculatorTests;

public class CalculatorSpecificationBase : SpecificationBase
{
    protected Calculator Calculator { get; } = new();
}
