using MyLib;

namespace MyLibUnitTests;

public class FooTests
{
    [Theory]
    [InlineData(-15, "fizzbuzz")]
    [InlineData(-9, "fizz")]
    [InlineData(-5, "buzz")]
    [InlineData(-3, "fizz")]
    [InlineData(-1, "-1")]
    [InlineData(0, "fizzbuzz")]
    [InlineData(1, "1")]
    [InlineData(3, "fizz")]
    [InlineData(5, "buzz")]
    [InlineData(6, "fizz")]
    [InlineData(15, "fizzbuzz")]
    [InlineData(43, "43")]
    public void FizzBuzz_Test(int input, string expectedOutput)
    {
        string output = Foo.FizzBuzz(input);

        Assert.Equal(expectedOutput, output);
    }
}