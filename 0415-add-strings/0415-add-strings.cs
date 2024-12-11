public class Solution {
    public string AddStrings(string num1, string num2) {
        // var sum=Convert.ToInt32(num1)+Convert.ToInt32(num2);
        //  return sum.ToString(); 
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        int carry = 0;
        var result = new StringBuilder();
        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digit1 = i >= 0 ? num1[i] - '0' : 0;
            int digit2 = j >= 0 ? num2[j] - '0' : 0;
            int sum = digit1 + digit2 + carry;
            result.Append(sum % 10);
            carry = sum / 10;
            i--;
            j--;
        }
        return new string(result.ToString().Reverse().ToArray());
    }
}