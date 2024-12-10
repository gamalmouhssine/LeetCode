public class Solution {
    public string IntToRoman(int num) {
       
        int[] Value = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        string[] Symbol = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        string roman = ""; 
    for (int i = 0; i < Value.Length && num > 0; i++) { 
        while (num >= Value[i]) {
            roman += Symbol[i];
            num -= Value[i];
        }
    }
    return roman;
    }
}