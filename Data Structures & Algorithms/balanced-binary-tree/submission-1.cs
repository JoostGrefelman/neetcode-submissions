/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {

    public bool IsBalanced(TreeNode root) {
        (bool res, int max) = dfs(root, 0);
        Console.WriteLine("total height = " + max);
        return res;
    }

    private (bool balanced, int height) dfs(TreeNode root, int currentHeight)
    {
        if(root == null) {
            return (true, 1);
        }

        (var leftBalanced, var leftHeight) = dfs(root.left, currentHeight);
        (var rightBalanced, var rightHeight) = dfs(root.right, currentHeight);
        var maxHeight = Math.Max(leftHeight, rightHeight) + 1;

        if(!leftBalanced 
        || !rightBalanced 
        || Math.Abs(leftHeight - rightHeight) > 1) {
            return (false, maxHeight);
        }

        return (true, maxHeight);
    }
    
}
