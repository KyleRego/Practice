namespace Challenges;

public class SortJumbledNumbers
{
    private int[] Mapping { get; set; } = [];

    private int Compare(int x, int y)
    {
        int mappedX = Map(x);
        int mappedY = Map(y);

        if (mappedX < mappedY)
        {
            return -1;
        }
        else if (mappedX > mappedY)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    private int Map(int a)
    {
        if (a == 0)
        {
            return Mapping[0];
        }

        List<int> digits = [];

        while (a != 0)
        {
            digits.Add(a % 10);
            a /= 10;
        }

        digits.Reverse();

        int result = 0;

        foreach (int digit in digits)
        {
            result = result * 10 + Mapping[digit];
        }

        return result;

        // this may be another way to implement this part
        // but it's even worse in time complexity
        // string asString = a.ToString();

        // string result = "";

        // for (int i = 0; i < asString.Length; i += 1)
        // {
        //     int digit = int.Parse(asString.Substring(i, 1));
        //     int mapped = Mapping[digit];
        //     result += mapped.ToString();
        // }

        // return int.Parse(result);
    }

    public int[] Soln(int[] mapping, int[] nums)
    {
        Mapping = mapping;
        List<int> input = [.. nums];

        input.Sort(Compare);

        return [.. input];
    }
}