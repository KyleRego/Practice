namespace Challenges;

// Future: Look at this one again, there are multiple approaches 
// including an interesting one that uses XOR
public class SingleNumber
{
    public static int Soln(int[] nums)
    {
        Dictionary<int, int> map = [];

        for (int i = 0; i < nums.Length; i += 1)
        {
            int num = nums[i];

            if (map.TryGetValue(num, out int count))
            {
                map[num] = count + 1;
            }
            else
            {
                map[num] = 1;
            }
        }

        foreach (int key in map.Keys)
        {
            if (map[key] == 1)
            {
                return key;
            }
        }

        return 0;
    }
}