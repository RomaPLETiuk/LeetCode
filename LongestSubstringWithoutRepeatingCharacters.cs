/*    MEdium
___________________________

Given a string s, find the length of the longest 
substring
 without repeating characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
    int maxLength = 0;
    int[] lastIndex = new int[256]; // Assuming ASCII character set

    // Initialize the last index of each character as -1
    for (int i = 0; i < 256; i++)
    {
        lastIndex[i] = -1;
    }

    int start = 0; // starting index of the current substring

    for (int i = 0; i < n; i++)
    {
        // If the current character is already present in the substring,
        // move the start pointer to the next position of the repeating character
        if (lastIndex[s[i]] >= start)
        {
            start = lastIndex[s[i]] + 1;
        }

        // Update the last index of the current character
        lastIndex[s[i]] = i;

        // Update the maximum length if required
        maxLength = Math.Max(maxLength, i - start + 1);
    }

    return maxLength; 
    }
}
