public class Solution {
    public string LongestCommonPrefix(string[] strs) {
         if (strs == null || strs.Length == 0)
        {
            return "";
        }

        var shortest = strs[0];
        if (strs.Length == 1)
        {
            return shortest;
        }

        for (int i = 0; i < shortest.Length; i++)
        {
            char currentChar = shortest[i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != currentChar)
                {
                    return shortest.Substring(0, i);
                }
            }
        }

        return shortest;
    }
}