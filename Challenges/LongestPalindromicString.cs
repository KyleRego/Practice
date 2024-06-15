namespace Challenges;

public class LongestPalindromicString
{
    // TODO: Solve this again, try to use a better algorithm, this one is bad
    public static string Soln(string input)
    {
        string answer = "";

        for (int i = 0; i < input.Length; i += 1)
        {
            for (int j = i; j < input.Length; j += 1)
            {
                string slice = input.Substring(i, j + 1 - i);

                if (slice.Length > answer.Length)
                {
                    if (IsPalindrome(slice))
                    {
                        answer = slice;
                    }
                }
            }
        }

        return answer;
    }

    public static bool IsPalindrome(string input)
    {
        char[] chars = input.ToCharArray();

        Array.Reverse(chars);

        string reverse = new(chars);

        return input == reverse;
    }

    public static bool IsPalindrome2(string input)
    {
        if (input.Length == 1) return true;

        int startIndex = 0;
        int endIndex = input.Length - 1;

        while (startIndex < endIndex)
        {
            char start = input[startIndex];
            char end = input[endIndex];

            if (start != end)
            {
                return false;
            }

            startIndex += 1;
            endIndex -= 1;
        }

        return true;
    }
}