public class Solution {
    public bool IsPalindrome(int x) {
         int reversed = 0;
            if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }
        while (x >reversed)
        {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x /= 10;
        }
       
        return x == reversed || x == reversed / 10;
    }
}