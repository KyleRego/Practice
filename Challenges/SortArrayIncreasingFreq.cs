using System.Collections.Immutable;

namespace Challenges;

public class SortArrayIncreasingFreq
{
    // holy cow this solution beat 100% at runtime
    // and 75% at memory, i did not expect it to be good
    public static int[] Soln(int[] nums)
    {
        // cheese solution: iterate over nums,
        // maintaining a map between num and frequency,
        // then use that map to create the result
        Dictionary<int, int> freqMap = [];

        for (int i = 0; i < nums.Length; i += 1)
        {
            int num = nums[i];

            if (freqMap.TryGetValue(num, out int _))
            {
                freqMap[num] += 1;
            }
            else
            {
                freqMap[num] = 1;
            }
        }

        // make a weird dictionary from that one

        Dictionary<int, List<int>> reverseFreqMap = [];

        foreach (var pair in freqMap)
        {
            int num = pair.Key;
            int frequency = pair.Value;

            if (reverseFreqMap.TryGetValue(frequency, out List<int>? value))
            {
                value.Add(num);
            }
            else
            {
                reverseFreqMap[frequency] = [num];
            }
        }

        // now iterate through the keys, which are the frequency, in ascending order

        List<int> result = [];

        int[] sortedKeys =  reverseFreqMap.Keys.ToArray();
        Array.Sort(sortedKeys);

        for (int i = 0; i < sortedKeys.Length; i += 1)
        {
            int frequency = sortedKeys[i];

            int[] nums2 = [.. reverseFreqMap[frequency]];

            Array.Sort(nums2);
            Array.Reverse(nums2);

            foreach (int n in nums2)
            {
                for (int h = 0; h < frequency; h += 1)
                {
                    result.Add(n);
                }
            }
        }

        return [.. result];
    }
}