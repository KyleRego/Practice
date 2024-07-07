namespace Challenges.Tests;

public class LetterCombinationsPhoneNumberTests
{
    [Fact]
    public void Test1()
    {
        string digits = "23";

        IList<string> result = LetterCombinationsPhoneNumber.LetterCombinations(digits);
        Assert.Equal(9, result.Count);

        string[] expected = ["ad","ae","af","bd","be","bf","cd","ce","cf"];

        foreach (string val in expected)
        {
            Assert.True(result.Contains(val));
        }
    }
}