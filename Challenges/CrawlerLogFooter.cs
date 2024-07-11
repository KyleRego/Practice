namespace Challenges;

public class CrawlerLogFooter
{
    public static int MinOperations(string[] logs)
    {
        int depth = 0;

        foreach (string log in logs)
        {
            if (log == "./")
            {
                continue;
            }
            else if (log == "../")
            {
                if (depth > 0)
                {
                    depth -= 1;
                }
            }
            else
            {
                depth += 1;
            }
        }

        return depth;
    }

    public static int StackSoln(string[] logs)
    {
        Stack<string> stack = [];

        foreach (string log in logs)
        {
            if (log == "../")
            {
                stack.Pop();
            }
            else if (log == "./")
            {
                continue;
            }
            else
            {
                stack.Push(log);
            }
        }

        return stack.Count;
    }
}