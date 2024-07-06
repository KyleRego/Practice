namespace Challenges.Tests;

public class NumberChallengeTests
{
    [Fact]
    public void Test1()
    {
        (double, double, double) result = NumberChallenge.ComputeIt();

        double apples = result.Item1;
        double bananas = result.Item2;
        double cpineapples = result.Item3;

        Console.WriteLine("applse, bananase, pinecapples");
        Console.WriteLine(apples);
        Console.WriteLine(bananas);
        Console.WriteLine(cpineapples);
    }
}