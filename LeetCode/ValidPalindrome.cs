﻿namespace LeetCode
{
    public static class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                while (left < right && char.IsLetterOrDigit(s[left])) left++;
                while (left < right && char.IsLetterOrDigit(s[right])) right--;
                if (char.ToLower(s[left]) != char.ToLower(s[right])) return false;

                left++;
                right--;
            }
            return true;
        }
    }
}
