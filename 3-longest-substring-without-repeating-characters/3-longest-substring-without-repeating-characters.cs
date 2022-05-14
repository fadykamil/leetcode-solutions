public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
        var dict = new Dictionary<char, int>();
        var max = 0;
        var j = 0;
        for (var i = 0; i < s.Length; i++)
        {
            var character = s[i];
            if (dict.ContainsKey(character))
                j = Math.Max(j, dict[character] + 1);
            dict[character] = i;

            max = Math.Max(max, i - j + 1);
        }

        return max;
    }
}