//1stApproach:
// Time Complexity: O(n^2), Space Complexity: O(1)
for (int i = 0; i <= nums.Length - 1; i++)

{
	for (int j = i + 1; j <= nums.Length - 1; j++)
	{
		if (nums[i] + nums[j] == target)
			return new int[] { i, j };
	}

}
return new int[] { -1, -1 };
//2nd Approach: / Using Dictionary for better time complexity
// Time Complexity: O(n), Space Complexity: O(n)
public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		Dictionary<int, int> map = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			int complement = target - nums[i];
			if (map.ContainsKey(complement))// yha pe check kr rhe hai ki complement value map me hai ya nhi
			{
				return new int[] { map[complement], i };// yha pe complement ki index and current index return kr rhe hai
			}
			else
			if (!map.ContainsKey(nums[i]))// yha pe duplicate values ko avoid krne ke liye check kr rhe hai
				map.Add(nums[i], i);// yha pe value as key and index as value store kr rhe hai

		}
		return new int[] { -1, -1 };
	}
}