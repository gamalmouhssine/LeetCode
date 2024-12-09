public class Solution {
    public bool IsSubsequence(string s, string t) {
         int i = 0, j = 0;
        for (j = 0; j < t.Length; j++)
        {
            if (i < s.Length && s[i] == t[j])
            {
                i++;
            }

            if (i == s.Length)
            {
                return true;
            }
        }

        return i == s.Length;
    }
}