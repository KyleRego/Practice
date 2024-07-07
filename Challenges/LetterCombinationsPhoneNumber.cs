using System.Data;

namespace Challenges;

public class LetterCombinationsPhoneNumber
{
    // If you solve this again later, see if
    // you can improve the space complexity
    public static IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0) return [];

        Dictionary<char, char[]> map = [];
        map['2'] = ['a', 'b', 'c'];
        map['3'] = ['d', 'e', 'f'];
        map['4'] = ['g', 'h', 'i'];
        map['5'] = ['j', 'k', 'l'];
        map['6'] = ['m', 'n', 'o'];
        map['7'] = ['p', 'q', 'r', 's'];
        map['8'] = ['t', 'u', 'v'];
        map['9'] = ['w', 'x', 'y', 'z'];

        List<string> result = [];

        BackTrack(digits, result, map, 0, "");

        return result;
    }

    private static void BackTrack(string digits, List<string> result, Dictionary<char, char[]> map, int i, string comb)
    {
        if (i == digits.Length)
        {
            result.Add(comb);
            return;
        }

        char currentDigit = digits[i];

        foreach (char mapped in map[currentDigit])
        {
            string nextComb = comb + mapped;

            BackTrack(digits, result, map, i + 1, comb);
        }
    }
}