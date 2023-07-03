/*Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*' where:

'?' Matches any single character.
'*' Matches any sequence of characters (including the empty sequence).
The matching should cover the entire input string (not partial).

 (Враховуючи вхідний рядок ( s) і шаблон ( p), реалізуйте шаблон підстановки з підтримкою '?'і '*'де:

'?'Відповідає будь-якому окремому символу.
'*'Відповідає будь-якій послідовності символів (включаючи порожню послідовність).
Зіставлення має охоплювати весь вхідний рядок (не частково).)

Example 1:

Input: s = "aa", p = "a"
Output: false
Explanation: "a" does not match the entire string "aa".
Example 2:

Input: s = "aa", p = "*"
Output: true
Explanation: '*' matches any sequence.
Example 3:

Input: s = "cb", p = "?a"
Output: false
Explanation: '?' matches 'c', but the second letter is 'a', which does not match 'b'.*/


public class Solution {
    public bool IsMatch(string s, string p) {
      int sLen = s.Length;
    int pLen = p.Length;
    int sIndex = 0;
    int pIndex = 0;
    int matchIndex = -1;
    int starIndex = -1;

    while (sIndex < sLen)
    {
        if (pIndex < pLen && (p[pIndex] == '?' || p[pIndex] == s[sIndex]))
        {
            sIndex++;
            pIndex++;
        }
        else if (pIndex < pLen && p[pIndex] == '*')
        {
            matchIndex = sIndex;
            starIndex = pIndex;
            pIndex++;
        }
        else if (starIndex != -1)
        {
            pIndex = starIndex + 1;
            matchIndex++;
            sIndex = matchIndex;
        }
        else
        {
            return false;
        }
    }

    while (pIndex < pLen && p[pIndex] == '*')
    {
        pIndex++;
    }

    return pIndex == pLen;  
    }
}
