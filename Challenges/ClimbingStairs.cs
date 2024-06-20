namespace Challenges;

// You are climbing a staircase. It takes n steps to reach the top.

// Each time you can either climb 1 or 2 steps.
// In how many distinct ways can you climb to the top?

public class ClimbingStairs
{
    public static int Soln(int n)
    {
        // number of ways to get n
        // = number of ways to get to n -2 + number of ways to get to n - 1
        // so this problem ends up being almost the Fibonacci sequence...

        if (n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }
        else
        {
            return Soln(n - 2) + Soln(n - 1);
        }
    }

    // use memoization

    public static int ClimbStairs(int n)
    {
        Dictionary<int, int> map = [];

        return Climb_Stairs(n, map);
    }

    private static int Climb_Stairs(int n, Dictionary<int, int> map)
    {
        if (n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }
        else
        {
            if (map.TryGetValue(n, out int val))
            {
                return val;
            }
            else
            {
                map[n] = Climb_Stairs(n - 1, map) + Climb_Stairs(n - 2, map);
                return map[n];
            }
        }
    }
}