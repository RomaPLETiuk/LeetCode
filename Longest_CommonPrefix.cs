/*            *Easy*
        _____________

Write a function to find the longest common prefix string amongst an array of strings.
If there is no common prefix, return an empty string "".

(Напишіть функцію для пошуку найдовшого спільного рядка префікса серед масиву рядків.
Якщо загального префікса немає, поверніть порожній рядок "".) 
___________
Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
___________
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.*/

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
             return "";

          string prefix = strs[0];
    for (int i = 1; i < strs.Length; i++)
    {
        while (strs[i].IndexOf(prefix) != 0)
        {
            prefix = prefix.Substring(0, prefix.Length - 1);
            if (string.IsNullOrEmpty(prefix))
                return "";
        }
    }

    return prefix;
    }
}
