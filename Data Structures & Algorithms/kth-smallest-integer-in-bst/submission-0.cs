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
    public int KthSmallest(TreeNode root, int k) {
      var values = new List<int>();
      InOrderTraversal(root, values);
      return values[k-1];
    }

    private TreeNode InOrderTraversal(TreeNode root, List<int> values) {
        
        if(root == null) {
            return null;
        }

        var left = InOrderTraversal(root.left, values);
        values.Add(root.val);
        var right = InOrderTraversal(root.right, values);

        return root;
    }
}
