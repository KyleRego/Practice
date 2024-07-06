namespace Challenges;

public class NumberChallenge
{
    public static (double, double, double) ComputeIt()
    {
        List<(double, double, double)> result = [];

        double apples = 1;
        double bananas = 1;
        double cpineapples = 1;

        BackTrack(apples, bananas, cpineapples, result);

        return result.First();
    }

    private static void BackTrack(double a, double b, double c, List<(double, double, double)> result)
    {
        if (result.Count == 1)
        {
            return;
        }

        if ((a / (b + c)) + (b / (a + c)) + (c / (a + b)) == 4)
        {
            result.Add((a, b, c));

            return;
        }
        else if (a > 50 || b > 50 || c > 50)
        {
            return;
        }
        else{
            BackTrack(a + 1, b, c, result);
            BackTrack(a, b + 1, c, result);
            BackTrack(a, b, c + 1, result);
        }
    }
}