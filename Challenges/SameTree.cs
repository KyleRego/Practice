namespace Challenges;

public class SameTree
{
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (p == null && q == null)
        {
            return true;
        }
        else if (p == null || q == null)
        {
            return false;
        }

        ArgumentNullException.ThrowIfNull(p);
        ArgumentNullException.ThrowIfNull(q);
        
        return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}