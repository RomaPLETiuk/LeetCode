/*        Medium
        ___________

     Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

 

Example 1:

Input: n = 3
Output: ["((()))","(()())","(())()","()(())","()()()"]
Example 2:

Input: n = 1
Output: ["()"]*/

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
       List <string>  result = new List<string>();
       Generate_Parententhesis(n, n, "", result);
       return result;


    }

   public void Generate_Parententhesis(int leftCount, int rightCount, string current, List<string> result){

      if (leftCount == 0 && rightCount == 0)
    {
        result.Add(current);
        return;
    }

    if (leftCount > 0)
    {
         Generate_Parententhesis(leftCount - 1, rightCount, current + "(", result);
    }

    if (rightCount > leftCount)
    {
         Generate_Parententhesis(leftCount, rightCount - 1, current + ")", result);
    }


   }
}


