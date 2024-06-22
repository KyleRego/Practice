namespace Challenges.Tests;

public class FibonacciNumberTests
{
    [Fact]
    public void Test()
    {
        Assert.Equal(0, FibonacciNumber.Fib3(0));
        Assert.Equal(1, FibonacciNumber.Fib3(1));
        Assert.Equal(1, FibonacciNumber.Fib3(2));
        Assert.Equal(2, FibonacciNumber.Fib3(3));
        Assert.Equal(3, FibonacciNumber.Fib3(4));
        Assert.Equal(5, FibonacciNumber.Fib3(5));
        Assert.Equal(8, FibonacciNumber.Fib3(6));
    }
}