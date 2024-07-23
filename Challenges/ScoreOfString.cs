namespace Challenges;

public class ScoreOfString
{
    // the score is the sum of the absolute difference between adjacent ASCII values

    public static int Soln(string s)
    {
        if (s.Length <= 1) return 0;

        int char1 = s[0];
        int char2 = s[1];

        static int AbsoluteDifference(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            else
            {
                return num2 - num1;
            }
        }

        int score = AbsoluteDifference(char1, char2);

        for (int i = 2; i < s.Length; i += 1)
        {
            char1 = char2;
            char2 = s[i];

            score += AbsoluteDifference(char1, char2);
        }

        return score;
    }
}