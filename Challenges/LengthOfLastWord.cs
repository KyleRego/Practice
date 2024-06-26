namespace Challenges;

public class LengthOfLastWord
{
    public static int Soln(string s)
    {
        string[] words = s.Split(" ");

        for (int i = words.Length - 1; i >= 0; i -= 1)
        {
            string word = words[i];

            if (word != "")
            {
                return word.Length;
            }
        }

        return -1;    
    }
}