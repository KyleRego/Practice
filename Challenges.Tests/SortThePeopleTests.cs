namespace Challenges.Tests;

public class SortThePeopleTests
{
    [Fact]
    public void Test1()
    {
        string[] names = ["Ryan", "Haley", "Drake"];
        int[] heights = [4, 1, 2];

        string[] result = SortThePeople.SortedDictionarySoln(names, heights);

        string[] expected = ["Ryan", "Drake", "Haley"];
        for (int i = 0; i < expected.Length; i += 1)
        {
            Assert.Equal(expected[i], result[i]);
        }
    }
}