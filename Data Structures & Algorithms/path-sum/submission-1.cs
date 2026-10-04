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
    private int sum = 0;

    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null) return false;

        sum += root.val;

        if(root.right == null && root.left == null) {
            bool matched = sum == targetSum;
            sum -= root.val;
            return matched;
        }

        if(HasPathSum(root.left, targetSum)) {
            return true;
        }
        if(HasPathSum(root.right, targetSum)) {
            return true;
        }

        sum -= root.val;

        return false;
    }
}