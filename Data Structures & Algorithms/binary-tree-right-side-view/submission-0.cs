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
    public List<int> RightSideView(TreeNode root) {
        if(root == null) return new List<int>();

        Queue<TreeNode> q = new Queue<TreeNode>();
        var result = new List<int>();
        q.Enqueue(root);

        while(q.Count > 0) {
            var levelLength = q.Count;
            var lastVal = 0;
            for(int i = 0; i < levelLength; i++) {
                var cur = q.Dequeue();
                lastVal = cur.val;

                if(cur.left != null) {
                    q.Enqueue(cur.left);
                }
                if(cur.right != null) {
                    q.Enqueue(cur.right);
                }
            }
            result.Add(lastVal);            
        }

        return result;

    }
}
