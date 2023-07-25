/*  EASY
____________
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 
Example 1:
Input: s = "()"
Output: true*/
public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> bracketPairs = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        foreach (char c in s)
        {
            if (bracketPairs.ContainsKey(c)) 
            {
                stack.Push(c);
            }
            else if (bracketPairs.ContainsValue(c)) 
            {
                if (stack.Count == 0 || bracketPairs[stack.Peek()] != c)
                {
                    return false; 
                }
                stack.Pop(); 
            }
            
        }

        return stack.Count == 0; 
    }
}
