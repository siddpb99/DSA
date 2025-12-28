public class Solution {
    public int ClimbStairs(int n) {
        
        int prev=2;
        int prev2=1;
        int curr=0;
        
        
        if(n<3)
        return n;
        
        for(int i =3;i<=n;i++)
        {
            curr= prev2+prev;
            prev2=prev;
            prev=curr;
        }
        
        return curr;
    }
}
