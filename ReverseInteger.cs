/* MEDIUM
  ________

Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

Example 1:

Input: x = 123
Output: 321  */
public class Solution {
    public int Reverse(int x) {
        long x1 = x; // Змінено тип змінної на long

        x1 = Math.Abs(x1);
        string s = x1.ToString();
        char[] Ar = s.ToCharArray();
        Array.Reverse(Ar);
        string s1 = new string(Ar);

        long rez = Int64.Parse(s1); // Змінено тип змінної на long

        if (x >= 0 && rez <= Int32.MaxValue) // Перевірка на переповнення
            return (int)rez;
        else if (x < 0 && -rez >= Int32.MinValue) // Перевірка на переповнення для від'ємних чисел
            return -(int)rez;
        else
            return 0; // Повертаємо 0 у випадку переповнення
    }
}
