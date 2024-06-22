namespace Challenges;

public class HouseRobber
{
    public static int Rob(int[] nums)
    {   
        Dictionary<(int, int), int> map = [];

        return Rob_Inner(nums, 0, nums.Length - 1, map);
    }

    private static int Rob_Inner(int[] nums, int start, int end, Dictionary<(int, int), int> map)
    {
        if (map.TryGetValue((start, end), out int value))
        {
            return value;
        }
        else
        {
            int maxMoneyRobbed = int.MinValue;

            for (int i = start; i <= end; i += 1)
            {
                int moneyRobbed = nums[i];

                if (i - 2 >= start)
                {
                    map[(start, i - 2)] = Rob_Inner(nums, start, i - 2, map);
                    moneyRobbed += map[(start, i - 2)];
                }

                if (i + 2 <= end)
                {
                    map[(i + 2, end)] = Rob_Inner(nums, i + 2, end, map);
                    moneyRobbed += map[(i + 2, end)];
                }

                if (moneyRobbed > maxMoneyRobbed)
                {
                    maxMoneyRobbed = moneyRobbed;
                }
            }

            map[(start, end)] = maxMoneyRobbed;
            return map[(start, end)];
        }
    }

    // The above solution is pretty bad in time and space complexity; a different attempt:
    // This solution is much better, especially with memory, but could be improved for time
    public static int Rob2(int[] nums)
    {
        Dictionary<int, int> map = [];

        return Rob2_Inner(nums, 0, map);
    }

    private static int Rob2_Inner(int[] nums, int startIndex, Dictionary<int, int> map)
    {
        if (startIndex >= nums.Length)
        {
            return 0;
        }
        else if (startIndex == nums.Length - 1)
        {
            return nums[^1];
        }

        if (map.TryGetValue(startIndex, out int value))
        {
            return value;
        }
        else
        {
            int num = nums[startIndex];

            int maximumPay = Math.Max(num + Rob2_Inner(nums, startIndex + 2, map),
                                        Rob2_Inner(nums, startIndex + 1, map));

            map[startIndex] = maximumPay;
            return map[startIndex];
        }
    }

    // Try another solution using a tabular approach
    // This turns out to be worse than the above
    public static int Rob3(int[] nums)
    {
        Dictionary<int, int> map = [];

        map[nums.Length] = 0;
        map[nums.Length - 1] = nums[^1];

        for (int i = nums.Length - 2; i >= 0; i -= 1)
        {
            map[i] = Math.Max(nums[i] + map[i + 2], map[i + 1]);
        }

        return map[0];
    }
}