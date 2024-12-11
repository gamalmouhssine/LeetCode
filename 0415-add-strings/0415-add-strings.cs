public class Solution {
    public string AddStrings(string num1, string num2) {
       // var sum=Convert.ToInt32(num1)+Convert.ToInt32(num2);
       //  return sum.ToString(); 
       BigInteger n1 = BigInteger.Parse(num1);
       BigInteger n2 = BigInteger.Parse(num2);
       BigInteger sum = n1 + n2;
       return sum.ToString();
    }
}