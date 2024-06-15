namespace Challenges;

public class RomanNumeral
{
    public static int RomanToInt(string s)
    {
        int result = 0;

        int pos = 0;

        while (pos < s.Length)
        {
            char c = s[pos];

            if (c == 'I')
            {
                if (pos + 1 < s.Length)
                {
                    char nextChar = s[pos + 1];

                    if (nextChar == 'V')
                    {
                        result += 4;
                        pos += 2;
                    }
                    else if (nextChar == 'X')
                    {
                        result += 9;
                        pos += 2;
                    }
                    else
                    {
                        result += 1;
                        pos += 1;
                    }
                }
                else
                {
                    result += 1;
                    pos += 1;
                } 
            }
            else if (c == 'X')
            {
                if (pos + 1 < s.Length)
                {
                    char nextChar = s[pos + 1];

                    if (nextChar == 'L')
                    {
                        result += 40;
                        pos += 2;
                    }
                    else if (nextChar == 'C')
                    {
                        result += 90;
                        pos += 2;
                    }
                    else
                    {
                        result += 10;
                        pos += 1;
                    }
                }
                else
                {
                    result += 10;
                    pos += 1;
                }
            }
            else if (c == 'C')
            {
                if (pos + 1 < s.Length)
                {
                    char nextChar = s[pos + 1];

                    if (nextChar == 'D')
                    {
                        result += 400;
                        pos += 2;
                    }
                    else if (nextChar == 'M')
                    {
                        result += 900;
                        pos += 2;
                    }
                    else
                    {
                        result += 100;
                        pos += 1;
                    }
                }
                else
                {
                    result += 100;
                    pos += 1;
                }
            }
            else if (c == 'V')
            {
                result += 5;
                pos += 1;
            }
            else if (c == 'L')
            {
                result += 50;
                pos += 1;
            }
            else if (c == 'D')
            {
                result += 500;
                pos += 1;
            }
            else if (c == 'M')
            {
                result += 1000;
                pos += 1;
            }
        }

        return result;
    }

    public static int RomanToInt2(string s)
    {
        int result = 0;
        int i = 0;

        while (i < s.Length)
        {
            char c = s[i];

            if (i + 1 < s.Length)
            {
                char nextChar = s[i + 1];

                int cVal = RomanValue(c);
                int nextVal = RomanValue(nextChar);

                if (nextVal > cVal)
                {
                    result += nextVal - cVal;
                    i += 2;
                }
                else
                {
                    result += cVal;
                    i += 1;
                }
            }
            else
            {
                result += RomanValue(c);
                i += 1;
            }
        }

        return result;
    }

    private static int RomanValue(char c)
    {
        switch (c)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
        }
        throw new Exception();
    }
}