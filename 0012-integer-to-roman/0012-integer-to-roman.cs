public class Solution {
    public string IntToRoman(int num) {
        var roman = new StringBuilder();
        int[] Value = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        string[] Symbol = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        for(int i=0;i<Value.Length;i++){
            while(num>=Value[i]){
                 roman.Append(Symbol[i]);
                 num -= Value[i];
            }
        }
        return roman.ToString();
    }
}