public class Solution {
    public int RomanToInt(string s) {
         Dictionary<char, int> romanToDecimal = new Dictionary<char, int> {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

         int result = 0;

        for (int i = 0; i < s.Length; i++) {
            int currentValue = romanToDecimal[s[i]];

            if (i < s.Length - 1 && romanToDecimal[s[i + 1]] > currentValue) {
                result -= currentValue;
            } else {
                result += currentValue;
            }
        }

        return result;
    }
}