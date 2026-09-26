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
    int preIndex = 0;
    Dictionary<int,int> hashMap = new Dictionary<int,int>();
    
    public TreeNode BuildTree(int[] preorder, int[] inorder) {  
        for (int i = 0; i < inorder.Length; i++) {
            hashMap.Add(inorder[i], i);
        }

        return BuildTree(inorder, preorder, 0, inorder.Length - 1);
    }

    private TreeNode BuildTree(int[] inorder, int[] preorder, int l, int r) 
    {
        if(l > r) {
            return null;
        }
        var val = preorder[preIndex];        
        var mid = hashMap[val];       
      
        preIndex++;
        var node = new TreeNode(val);
        node.left = BuildTree(inorder, preorder, l, mid - 1);
        node.right = BuildTree(inorder, preorder, mid + 1, r);

        return node;
    }

    
}
