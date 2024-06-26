namespace Challenges.Tests;

public class IndexOfFirstOccurrenceTests
{
    [Fact]
    public void Test1()
    {
        string haystack = "sadbutsad";
        string needle = "sad";

        int result = IndexOfFirstOccurrence.StrStr(haystack, needle);

        Assert.Equal(0, result);
    }

    [Fact]
    public void Test2()
    {
        string haystack = "leetcode";
        string needle = "leeto";

        int result = IndexOfFirstOccurrence.StrStr(haystack, needle);

        Assert.Equal(-1, result);
    }
}