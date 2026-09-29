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
    public List<List<int>> LevelOrder(TreeNode root) {
        if(root == null) return new List<List<int>>();

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        List<List<int>> result = new List<List<int>>();
        
        while(queue.Count > 0) {
            var levelLength = queue.Count;
            var levelResult = new List<int>();            
            for(int i =0; i < levelLength; i++) {
                var cur = queue.Dequeue();
                levelResult.Add(cur.val);
                if(cur.left != null) {
                    queue.Enqueue(cur.left);
                }
                if(cur.right != null) {
                    queue.Enqueue(cur.right);
                }
            }
            result.Add(levelResult);
        }

        return result;
    }
}
