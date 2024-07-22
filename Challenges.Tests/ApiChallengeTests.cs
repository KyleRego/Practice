namespace Challenges.Tests;

public class SolveTestTests
{
    [Fact]
    public async void Test1()
    {
        // await SolveTest.Attempt();
    }

    [Fact]
    public void Test2()
    {
        string input = "task_[53,97,51,97,56,55,56,102,53,57,49,100,55,101,52,53,52,97,48,101,57,51,55,54,49,49,53,98,55,49,97,52]";

        string result = SolveTest.UnencryptStringWithJsonArray(input);
    }

    [Fact]
    public async void Test3()
    {
        string input = "task_577646548c206dc8e31ac3cde2bb23dd";

        string result = SolveTest.UnencryptSwappedEveryPair(input);
    }

    [Fact]
    public async void Test4()
    {
        Assert.Equal("task_2134", SolveTest.UnencryptSwappedEveryPair("task_1243"));
    }

    [Fact]
    public async void Test5()
    {
        string input = @"task_'.)([,,(+\)\('W-(W&([Z,,Y**,*&/Y";

        string result = SolveTest.UnencryptByAddingNum(input, 10);
    }

    [Fact]
    public async void Test6()
    {
        string input1 = "added -10 to ASCII value of each character";

        string input2 = "added -1 to ASCII value of each character";

        Assert.Equal(-10, SolveTest.WhatWasSubtracted(input1));

        Assert.Equal(-1, SolveTest.WhatWasSubtracted(input2));
    }

    [Fact]
    public async void Test7()
    {
        string input = "hex decoded, encrypted with XOR, hex encoded again. key: secret";

        Assert.Equal("secret", SolveTest.ExtractTheKey(input));
    }

    [Fact]
    public async void Test8()
    {
        string input = "task_68b1cb2eac9d1ed7510f4ad8b42a38f0";

        string result = SolveTest.UnencryptXorAndHex(input, "secret");

        string input2 = "task_fa616875178247292b0301f7fe7ff1";

        string result2 = SolveTest.UnencryptXorAndHex(input2, "secret");

    }

    [Fact]
    public async void Test9()
    {
        string input = "task_68b1cb2eac9d1ed7510f4ad8b42a38f0";

        string result = SolveTest.UnencryptXorAndHex(input, "secret");

        string resultOfDoingItAgain = SolveTest.UnencryptXorAndHex(result, "secret");
        // this does pass...
        Assert.Equal(input, resultOfDoingItAgain);
    }
}