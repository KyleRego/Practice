namespace Challenges;

public class MaximumScoreFromRemovingSubstrings
{
    // Backtracking seems to work.. but the time limit is exceeded
    // with this solution

    // Checking the constraint on the length of s, it is obvious
    // that backtracking would not work for this... s can be very long
    public static int MaximumGain(string s, int x, int y)
    {
        List<int> scores = [];

        BackTrack(s, scores, 0, x, y);
        BackTrack(s, scores, 0, x, y);

        return scores.Max();
    }

    private static void BackTrack(string s, List<int> scores, int score, int x, int y)
    {
        List<int> removeIndicesA = [];
        List<int> removeIndicesB = [];

        for (int i = 0; i < s.Length - 1; i += 1)
        {
            string substring = s.Substring(i, 2);

            if (substring == "ab")
            {
                removeIndicesA.Add(i);
            }
            else if (substring == "ba")
            {
                removeIndicesB.Add(i);
            }
        }

        if (removeIndicesA.Count == 0 && removeIndicesB.Count == 0)
        {
            scores.Add(score);
        }
        else
        {
            foreach (int removeIndexA in removeIndicesA)
            {
                BackTrack(s.Remove(removeIndexA, 2), scores, score + x, x, y);
            }

            foreach (int removeIndexB in removeIndicesB)
            {
                BackTrack(s.Remove(removeIndexB, 2), scores, score + y, x, y);
            }
        }
    }
}