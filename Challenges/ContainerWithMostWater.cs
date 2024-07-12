namespace Challenges;

public class Water
{
    // Bad check every possible solution approach
    public static int MaxArea(int[] height)
    {
        int maxArea = 0;

        for (int i = 0; i < height.Length; i += 1)
        {
            for (int j = i + 1; j < height.Length; j += 1)
            {
                int area = Area(i, j, height);

                if (area > maxArea)
                {
                    maxArea = area;
                }
            }
        }

        return maxArea;
    }

    private static int Area(int i, int j, int[] heights)
    {
        int width = j - i;
        int height1 = heights[i];
        int height2 = heights[j];

        int height = (height1 > height2) ? height2 : height1;

        return width * height;
    }

    // 7/12/2 a much better solution (can't say I came up with
    // it since I read the editorial after the last time)
    public static int Soln(int[] heights)
    {
        if (heights.Length == 0) return 0;
        if (heights.Length == 1) return heights[0];

        int left = 0;
        int right = heights.Length - 1;

        int maxArea = 0;

        while (left != right)
        {
            int leftHeight = heights[left];
            int rightHeight = heights[right];

            if (leftHeight >= rightHeight)
            {
                int area = rightHeight * (right - left);

                if (area > maxArea)
                {
                    maxArea = area;
                }

                right -= 1;
            }
            else if (rightHeight > leftHeight)
            {
                int area = leftHeight * (right - left);

                if (area > maxArea)
                {
                    maxArea = area;
                }

                left += 1;
            }
        }

        return maxArea;
    }
}