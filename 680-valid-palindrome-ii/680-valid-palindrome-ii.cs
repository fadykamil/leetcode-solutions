public class Solution {
    public bool ValidPalindrome(string s)
    {
        var start = 0;
        var end = s.Length - 1;
        while (start < end)
        {
            if (s[start] != s[end])
                return IsPalindrome(s, start, end - 1) || IsPalindrome(s, start + 1, end);
            start++;
            end--;
        }

        return true;
    }

    private bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start] != s[end])
                return false;

            start++;
            end--;
        }

        return true;
    }
}