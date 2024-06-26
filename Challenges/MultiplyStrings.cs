namespace Challenges;

public class MultiplyStrings
{
    // This solution doesn't work and also converts the 
    // string inputs to numbers directly which is not
    // allowed by the problem description
    // TODO: Revisit
    public static string Multiply(string num1, string num2)
    {
        return (StringToInt(num1) * StringToInt(num2)).ToString();
    }

    public static double StringToInt(string s)
    {
        double result = 0;

        for (int i = 0; i < s.Length; i += 1)
        {
            result = result * 10 + (s[i] - '0');
        }

        return result;
    }
}