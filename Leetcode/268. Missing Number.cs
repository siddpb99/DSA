public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length; int res = 0; int sum = 0; int sumnums = 0;//isme sum me pura no ka sum 
        for (int i = 0; i < n; i++)//aur sumnums me jo v nums k andar uska sum fir subtract krnepe missing
        {

            sumnums = sumnums + nums[i];
        }
        for (int i = 0; i <= n; i++)// sum=n*(n+1)/2; isko v use kr skte h bina loop k
        {

            sum = sum + i;
        }
        res = sum - sumnums;
        return res;
    }
}