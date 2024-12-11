public class Solution {
    public string LargestNumber(int[] nums) {
        var numStrings = nums.Select(n => n.ToString()).ToArray();
        Array.Sort(numStrings, (a, b) => (b + a).CompareTo(a + b));
        if (numStrings[0] == "0") return "0";
        var result = string.Join("", numStrings);
        return result;
    }
}