namespace Challenges;

public class SplitString
{
    public static string[] Solution(string str)
    {
        // this could be declared an array
        // half the length of str
        List<string> result = [];

        for (int i = 0; i < str.Length - 1; i += 2)
        {
            result.Add(str.Substring(i, 2));
        }

        if (str.Length % 2 == 1)
        {
            result.Add(str.Last().ToString() + "_");
        }

        return [.. result];
    }
}