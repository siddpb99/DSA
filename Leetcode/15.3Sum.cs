public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        //sbse pehle array ko sort karenge
        //isme sbse pehle ek for loop chalayenge aur duplicate ko skip krenge
        //usme ek 1st number lenge fir uske next no ko left aur laast ko right maan lenge, current   no. fix rhega aur left ya right ko adjust krenge
        // left ko tb adjust krenge jb sum 0 se jyada ho
        // nhi to right ko krenge
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;//duplicate ko skip

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Skip duplicates
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }
        return result;



    }
}