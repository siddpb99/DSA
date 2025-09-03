public class Solution
{
	public int[] CountBits(int n)
	{
		int[] res = new int[n + 1];//brute force approach hai
		for (int i = 0; i <= n; i++)
		{
			int count = 0;
			int num = i; // maan lo no. hai i=0 to 0 k liye count 
			while (num > 0) //ye count nikalne k liye hai
			{

				count = count + num % 2;
				num = num >> 1; // right shift
			}
			res[i] = count;
		}
		return res;
	}
}

//ye brute force nhi optimized hai
// Problem: 338. Counting Bits
// Link: https://leetcode.com/problems/counting-bits/
// Approach: Dynamic Programming using Bit Manipulation
// Time Complexity: O(n), Space Complexity: O(n)

public class Solution
{
	public int[] CountBits(int n)
	{
		int[] res = new int[n + 1];
		for (int i = 1; i <= n; i++)
		{
			res[i] = res[i >> 1] + (i & 1);
		}
		return res;
	}
}