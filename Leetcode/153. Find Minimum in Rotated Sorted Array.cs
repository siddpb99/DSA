public class Solution {
    public int FindMin(int[] nums) {
        //isme hmlog binary searh type kch use kr skte h kyuki log n me chaiye  
        //isiliye isme hmlog mid nikal lenge fir scheck krenge ki kya mid ka value first se bara h
        // agr ha iska mtlb hua ki left me chota value milega
        //otherwise right me
        int left=0;
        int right=nums.Length -1;
        
        while(left<right){
            int mid = left + (right - left) / 2;
            if(nums[mid]>nums[right])//agr mid ka value right se bara h 
        { 
            left=mid+1;// to iska mtlb ki left me chota value hoga as 7>2 to left me nhi hoga right 
        }
        else{
            right =mid;
        }
        }
        return nums[left];
    }
}