namespace Challenges;

public class PalindromeNumber
{
    public static bool Soln(int x)
    {
        string forward = x.ToString();

        string backward = Reverse(forward);

        return forward == backward;
    }

    private static string Reverse(string s)
    {
        char[] chars = s.ToCharArray();

        Array.Reverse(chars);

        return new string(chars);
    }
}