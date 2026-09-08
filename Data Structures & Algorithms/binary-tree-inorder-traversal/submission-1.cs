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
    public List<int> InorderTraversal(TreeNode root) {  
        var res = new List<int>();
        InOrder(root, res);
        return res;
    }

    private void InOrder(TreeNode root, List<int> res) {
        if (root == null)  {
            return;
        }  

        InOrder(root.left, res);
        res.Add(root.val);
        InOrder(root.right, res);
    }
}