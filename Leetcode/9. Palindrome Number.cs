// LeetCode Problem 9: Palindrome Number
// Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
//Time Complexity: O(log10(n)) where n is the input number
// Space Complexity: O(1)
// Example 1: Input: x = 121
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        int original = x;
        int reversed = 0;
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10; // Get the last digit and add it to reversed
            x = x / 10;
        }
        return original == reversed;
    }
}
