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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null)
        {
            return null;
        }
        Console.WriteLine($"Delete key {key} at node {root.val}");
        
        if(key > root.val) {
            root.right = DeleteNode(root.right, key);
        } else if (key < root.val) {
            root.left = DeleteNode(root.left, key);
        } else {
            //found it!
            if (root.left == null) {
                return root.right;
            } else if (root.right == null) {
                return root.left;
            } else {
                var minNode = FindMinNode(root.right);
                Console.WriteLine($"Minnode val is {minNode.val}");
                root.val = minNode.val;
                root.right = DeleteNode(root.right, minNode.val);
            }
        }

        return root;
    }

    public TreeNode FindMinNode(TreeNode root)
    {
        var cur = root;
        while(cur.left != null) {
            cur = cur.left;
        }

        return cur;
    }
}