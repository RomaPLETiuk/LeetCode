/*Given a binary tree, determine if it is height-balanced


Example 1:

Input: root = [3,9,20,null,null,15,7]
Output: true
Example 2:

Input: root = [1,2,2,3,3,null,null,4,4]
Output: false
Example 3:

Input: root = []
Output: true*/

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
        if (root == null)
            return true;

       // return  GetHeight(root.left)==GetHeight(root.right); 
       int leftHeight = GetHeight(root.left);
        int rightHeight = GetHeight(root.right);
        
        if (Math.Abs(leftHeight - rightHeight) > 1)
            return false;
        
        return IsBalanced(root.left) && IsBalanced(root.right);  

    }

     private int GetHeight(TreeNode node)
    {
        if (node == null)
            return 0;
        
        int leftHeight = GetHeight(node.left);
        int rightHeight = GetHeight(node.right);
        
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
