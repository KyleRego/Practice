using System.Collections.Generic;

namespace Challenges;

// TODO: Study this problem again; there are multiple better
// solutions with interesting space/time complexities
public class LongestCommonPrefix
{
    public static string Soln(string[] strs)
    {
        string longestCommonPrefix = "";

        int shortestLength = ShortestLength(strs);

        for (int i = 0; i < shortestLength; i += 1)
        {
            List<char> chars = new();

            foreach (string str in strs)
            {
                char c = str[i];

                if (!chars.Contains(c))
                {
                    chars.Add(str[i]);
                }
            }

            if (chars.Count == 1)
            {
                longestCommonPrefix += chars.First();
            }
            else
            {
                break;
            }
        }

        return longestCommonPrefix;
    }

    private static int ShortestLength(string[] strs)
    {
        int shortestLength = -1;

        foreach (string str in strs)
        {
            if (shortestLength == -1)
            {
                shortestLength = str.Length;
            }
            else
            {
                if (str.Length < shortestLength)
                {
                    shortestLength = str.Length;
                }
            }
        }

        return shortestLength;
    }
}