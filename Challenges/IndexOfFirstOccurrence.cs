namespace Challenges;

public class IndexOfFirstOccurrence
{
    public static int StrStr(string haystack, string needle)
    {
        for (int i = 0; i < haystack.Length; i += 1)
        {
            if (i + needle.Length > haystack.Length)
            {
                return -1;
            }

            for (int j = 0; j < needle.Length; j += 1)
            {
                char hChar = haystack[i + j];
                char nChar = needle[j];

                if (hChar != nChar)
                {
                    break;
                }

                if (j == needle.Length - 1)
                {
                    return i;
                }
            }
        }

        return -1;
    }
}