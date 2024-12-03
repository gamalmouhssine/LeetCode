public class Solution {
    public int MaxVowels(string s, int k) {
         int maxCount = 0;
        int count = 0;
        string vowels = "aeiou";
        for (int i = 0; i < k; i++) {
            if (vowels.Contains(s[i])) {
                count++;
            }
        }
        maxCount = count;
        for (int i = k; i < s.Length; i++) {
            if (vowels.Contains(s[i - k])) {
                count--;
            }
            if (vowels.Contains(s[i])) {
                count++;
            }
            maxCount = Math.Max(maxCount, count);
        }
        return maxCount;
    }
}