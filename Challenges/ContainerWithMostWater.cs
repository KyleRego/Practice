namespace Challenges;

public class Water
{
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
}