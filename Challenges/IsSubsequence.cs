namespace Challenges;

public class IsSubsequence
{
    public static bool Soln(string s, string t)
    {
        int sIndex = 0;
        int tIndex = 0;

        while (sIndex < s.Length)
        {
            char sChar = s[sIndex];

            if (tIndex < t.Length)
            {
                char tChar = t[tIndex];

                if (sChar == tChar)
                {
                    sIndex += 1;
                    tIndex += 1;
                }
                else
                {
                    tIndex += 1;
                }
            }
            else
            {
                return false;
            }

            
        }

        return true;
    }
}