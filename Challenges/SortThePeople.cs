namespace Challenges;

public class SortThePeople
{
    public static string[] Soln(string[] names, int[] heights)
    {
        Dictionary<int, int> heightsToIndexes = [];

        if (names.Length <= 1) return names;

        // One pass through heights - O(m)
        for (int i = 0; i < heights.Length; i += 1)
        {
            heightsToIndexes[heights[i]] = i;
        }

        // Sorting and reversing through (m) with standard library
        int[] sortedHeights = heightsToIndexes.Keys.ToArray();
        Array.Sort(sortedHeights);
        Array.Reverse(sortedHeights);

        string[] newNames = new string[names.Length];

        // Another pass through
        for (int i = 0; i < sortedHeights.Length; i += 1)
        {
            newNames[i] = names[heightsToIndexes[sortedHeights[i]]];
        }

        return newNames;
    }

    public static string[] BetterSoln(string[] names, int[] heights)
    {
        if (names.Length <= 1) return names;
        // A better approach would create a dictionary<int, name>
        // that maps the height to the corresponding name!

        Dictionary<int, string> map = [];

        for (int i = 0; i < names.Length; i += 1)
        {
            map[heights[i]] = names[i];
        }

        // Mess with heights in place - this is a side effect
        Array.Sort(heights);
        Array.Reverse(heights);

        for (int i = 0; i < heights.Length; i += 1)
        {
            // Mess with names in place too 
            names[i] = map[heights[i]];
        }

        return names;
    }

    // there is a SortedDictionary class in C#
    // this solution turns out to be much worse in run time than the previous
    public static string[] SortedDictionarySoln(string[] names, int[] heights)
    {
        if (names.Length <= 1) return names;

        SortedDictionary<int, string> map = [];

        for (int i = 0; i < names.Length; i += 1)
        {
            map[heights[i]] = names[i];
        }

        string[] newNames = new string[names.Length];

        // not sure about the best way to iterate through in reverse to
        // take advantage of the sorted keys

        // int j = 0;
        // foreach (int height in map.Keys.Reverse())
        // {
        //     newNames[j] = map[height];
        //     j += 1;
        // }

        // iterating through like this instead does not help much
        int j = 0;
        foreach (int height in map.Keys)
        {
            newNames[names.Length - 1 - j] = map[height];
            j += 1;
        }

        return newNames;
    }
}