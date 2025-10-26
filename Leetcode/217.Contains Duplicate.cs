//Time Complexity: O(n), Space Complexity: O(n)
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();// hashset use kr rhe hai kyuki ek hi value store krni hai aur duplicate avoid krne hai
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.Contains(nums[i]))
                return true;
            else
                seen.Add(nums[i]);
        }
        return false;
    }
}
//Alternate Approach using Sorting
//Time Complexity: O(n log n) due to sorting, Space Complexity: O(1) if in-place sorting is used
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        Array.Sort(nums);// array ko sort kr denge
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])// adjacent elements ko compare krenge
                return true;
        }
        return false;
    }
}