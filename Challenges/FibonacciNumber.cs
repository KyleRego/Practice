namespace Challenges;

public class FibonacciNumber
{
    // Recursion; takes too long for large n
    public static int Fib(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        return Fib(n - 1) + Fib(n - 2);
    }

    // use memoization

    private static Dictionary<int, int> map = [];

    public static int Fib2(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        if (map.TryGetValue(n, out int val))
        {
            return val;
        }
        else
        {
            map[n] = Fib2(n - 1) + Fib2(n - 2);
            return map[n];
        }
    }

    // use tabulation
    public static int Fib3(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int[] sequence = new int[n + 1];

        sequence[0] = 0;
        sequence[1] = 1;

        for (int i = 2; i <= n; i += 1)
        {
            sequence[i] = sequence[i - 1] + sequence[i - 2];
        }

        return sequence[n];
    }
}