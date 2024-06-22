namespace Challenges;

public class SearchInsertPosition
{
    public static int SearchInsert2(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i += 1)
        {
            int num = nums[i];

            if (num == target)
            {
                return i;
            }
            else if (num > target)
            {
                return i;
            }
        }

        return nums.Length;    
    }

    // use binary search

    public static int SearchInsert(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int searchIndex = left + (right - left) / 2 ;
            int num = nums[searchIndex];

            if (num == target)
            {
                return searchIndex;
            }
            else if (num < target)
            {
                left = searchIndex + 1;
            }
            else if (num > target)
            {
                right = searchIndex - 1;
            }
        }

        return left;
    }
}