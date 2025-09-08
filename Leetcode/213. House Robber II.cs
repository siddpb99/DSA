public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        if (nums.Length == 2) return Math.Max(nums[0], nums[1]);
        return Math.Max(rob(nums, 0, nums.Length - 2), rob(nums, 1, nums.Length - 1));
        // ek 1st value ko include kr k last ko chor k
        //dusra last ko leke 1st ko chor k so 2 baar jaayega rob me jiska max hoga wo return krega
    }
    private int rob(int[] nums, int start, int end)
    {
        int prev1 = nums[start];
        int prev2 = Math.Max(nums[start], nums[start + 1]);
        for (int i = start + 2; i <= end; i++)
        {

            int current = Math.Max(prev2, prev1 + nums[i]);
            prev1 = prev2;
            prev2 = current;
        }
        return prev2;
    }
}