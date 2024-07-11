namespace Challenges;

public class ReverseSubstringsInsideParentheses
{
    // it's a solution but it does terribly at runtime and memory
    // (only better than 5% of submissions at both)
    // the algorithm is clearly bad: it does a pass through s
    // for each parentheses-substring to reverse
    public static string ReverseParentheses(string s)
    {
        int left = -1;
        int right = -1;

        int len = s.Length;

        for (int i = 0; i < len; i += 1)
        {
            char curChar = s[i];

            if (curChar == '(')
            {
                left = i;
            }
            else if (curChar == ')')
            {
                right = i;

                string toReplace = s.Substring(left, right - left + 1);
                string toReverse = s.Substring(left + 1, right - left - 1);

                string reversed = "";
                for (int j = toReverse.Length - 1; j >= 0; j -= 1)
                {
                    reversed += toReverse[j];
                }

                // since this replaces all occurrences, 
                // it is a bit dangerous to use here
                // since this assumes it only replaces the current occurrence
                // using s.Remove() and s.Insert() is a much better way
                s = s.Replace(toReplace, reversed);

                i = -1;
                len = s.Length;
                left = -1;
                right = -1;
            }
        }

        return s;
    }

    // this is much better, it beats 80% at runtime.
    // but its about the same for memory
    public static string AnotherSoln(string s)
    {
        Stack<int> leftParentheses = [];

        int len = s.Length;

        for (int i = 0; i <= len - 1; i += 1)
        {
            if (s[i] == '(')
            {
                leftParentheses.Push(i);
            }
            else if (s[i] == ')')
            {
                int left = leftParentheses.Pop();
                int right = i;

                string toReverse = s.Substring(left + 1, right - left - 1);

                string reversed = "";
                for (int j = toReverse.Length - 1; j >= 0; j -= 1)
                {
                    reversed += toReverse[j];
                }

                s = s.Remove(left, right - left + 1);
                s = s.Insert(left, reversed);
                len -= 2;

                i -= 2;
            }
        }

        return s;
    }
}