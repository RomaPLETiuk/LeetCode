/*  Medium
 ___________
 Given a string s, return the longest palindromic substring in s.
*Example 1:
Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
*Example 2:
Input: s = "cbbd"
Output: "bb"*/

public class Solution {
    public string LongestPalindrome(string s) {
      if (string.IsNullOrEmpty(s)) return string.Empty;

        int start = 0;
        int maxLength = 1;
      

        for (int i = 0; i < s.Length; i++) {
            
            int oddLength = ExpandAroundCenter(s, i, i);
           
            int evenLength = ExpandAroundCenter(s, i, i + 1);

            int length = Math.Max(oddLength, evenLength);

            if (length > maxLength) {
                maxLength = length;
                start = i - (length - 1) / 2;
            }
        }

        return s.Substring(start, maxLength);  
    }

    private int ExpandAroundCenter(string s, int left, int right) {
        // Expand around the center (left, right) to find the length of the palindrome.
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        // Return the length of the palindrome.
        return right - left - 1;
    }
}
