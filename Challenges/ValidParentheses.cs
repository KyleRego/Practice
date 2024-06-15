namespace Challenges;

public class ValidParentheses
{

    public static bool IsValid(string s)
    {
        Stack<char> stack = [];

        int i = 0;

        while (i < s.Length)
        {
            char c = s[i];

            if (c == '[' || c == '{' || c == '(')
            {
                stack.Push(c);
            }
            else if (c == ']' || c == '}' || c == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                if (c == ']')
                {
                    char last = stack.Pop();

                    if (last != '[')
                    {
                        return false;
                    }
                }
                else if (c == ')')
                {
                    char last = stack.Pop();

                    if (last != '(')
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    char last = stack.Pop();

                    if (last != '{')
                    {
                        return false;
                    }
                }
            }

            i += 1;
        }

        return stack.Count == 0;
    }
}