namespace Challenges;

public class AddBinary
{
    // This passes but is not great
    // Probably revisit this later to try for a more elegant solution
    // There are also some other ways to solve
    public static string Soln(string a, string b)
    {
        List<char> result = [];

        char carry = '0';

        for (int i = 0; i <= a.Length - 1 || i <= b.Length - 1; i += 1)
        {
            char aDigit;
            char bDigit;

            if (i <= a.Length - 1)
            {
                aDigit = a[a.Length - 1 - i];
            }
            else
            {
                aDigit = '0';
            }

            if (i <= b.Length - 1)
            {
                bDigit = b[b.Length - 1 - i];
            }
            else
            {
                bDigit = '0';
            }

            int sum = 0;
            if (carry == '1') sum += 1;
            if (aDigit == '1') sum += 1;
            if (bDigit == '1') sum += 1;

            if (sum == 0)
            {
                result.Add('0');
                carry = '0';
            }
            else if (sum == 1)
            {
                result.Add('1');
                carry = '0';
            }
            else if (sum == 2)
            {
                result.Add('0');
                carry = '1';
            }
            else if (sum == 3)
            {
                result.Add('1');
                carry = '1';
            }
            else
            {
                throw new ApplicationException();
            }
        }

        if (carry == '1')
        {
            result.Add('1');
        }

        string strResult = "";

        for (int i = result.Count - 1; i >= 0; i -= 1)
        {
            char c = result[i];
            strResult += c;
        }

        return strResult;
    }
}