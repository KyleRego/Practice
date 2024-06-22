namespace Challenges;

public class IsomorphicStrings
{
    public static bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map = [];
        Dictionary<char, char> inverseMap = [];

        for (int i = 0; i < s.Length; i += 1)
        {
            char sChar = s[i];
            char tChar = t[i];

            if (map.TryGetValue(sChar, out char sCharMapped))
            {
                if (sCharMapped != tChar)
                {
                    return false;
                }
            }
            else if (inverseMap.TryGetValue(tChar, out char mappedToTChar))
            {
                if (mappedToTChar != sChar)
                {
                    return false;
                }
            }
            else
            {
                map[sChar] = tChar;
                inverseMap[tChar] = sChar;
            }
        }

        return true;
    }
}